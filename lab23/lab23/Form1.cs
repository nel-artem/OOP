using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawHypocycloid(double R, double r, PictureBox canvas)
        {
            int width = canvas.Width;
            int height = canvas.Height;

            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Центр координат
            int cx = width / 2;
            int cy = height / 2;

            double m = r / R;

            // Масштаб — щоб крива вміщалась у PictureBox
            double scale = (Math.Min(width, height) / 2.0) / R * 0.85;

            DrawAxes(g, cx, cy, width, height);

            // Малюємо криву
            Pen curvePen = new Pen(Color.Blue, 2);
            double step = 0.001;
            double tMax = 2 * Math.PI * GetPeriods(r, R);

            double? prevX = null, prevY = null;

            for (double t = 0; t <= tMax; t += step)
            {
                double x = (R - m * R) * Math.Cos(m * t) + m * Math.Cos(t - m * t);
                double y = (R - m * R) * Math.Sin(m * t) - m * Math.Sin(t - m * t);

                double screenX = cx + x * scale;
                double screenY = cy - y * scale;

                if (prevX.HasValue)
                {
                    g.DrawLine(curvePen,
                        (float)prevX.Value, (float)prevY.Value,
                        (float)screenX, (float)screenY);
                }

                prevX = screenX;
                prevY = screenY;
            }

            canvas.Image = bmp;

            g.Dispose();
            curvePen.Dispose();
        }

        private void DrawAxes(Graphics g, int cx, int cy, int width, int height)
        {
            Pen axisPen = new Pen(Color.Black, 1.5f);
            Font font = new Font("Arial", 8);
            Brush brush = Brushes.Black;

            // Осі X і Y
            g.DrawLine(axisPen, 0, cy, width, cy);
            g.DrawLine(axisPen, cx, 0, cx, height);

            // Стрілки
            g.DrawLine(axisPen, width - 10, cy - 5, width, cy);
            g.DrawLine(axisPen, width - 10, cy + 5, width, cy);
            g.DrawLine(axisPen, cx - 5, 10, cx, 0);
            g.DrawLine(axisPen, cx + 5, 10, cx, 0);

            // Підписи осей
            g.DrawString("X", font, brush, width - 15, cy + 5);
            g.DrawString("Y", font, brush, cx + 5, 5);
            g.DrawString("0", font, brush, cx + 3, cy + 3);

            axisPen.Dispose();
            font.Dispose();
        }

        // Визначає скільки повних обертів потрібно для замкнутої кривої
        private int GetPeriods(double r, double R)
        {
            int ri = (int)Math.Round(r);
            int Ri = (int)Math.Round(R);
            if (ri == 0 || Ri == 0) return 1;

            int gcd = GCD(ri, Ri);
            return Ri / gcd;
        }

        private int GCD(int a, int b)
        {
            while (b != 0) { int t = b; b = a % b; a = t; }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R = double.Parse(textBoxR.Text);
                double r = double.Parse(textBox_r.Text);

                if (R <= 0 || r <= 0)
                    throw new ArgumentException("R і r повинні бути більше нуля.");

                if (r >= R)
                    throw new ArgumentException("r повинно бути менше R.");

                DrawHypocycloid(R, r, pictureBox1);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть коректні числові значення.", "Помилка");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }
    }


}
