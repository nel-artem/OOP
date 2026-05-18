using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab18
{
    public partial class lab18 : Form
    {
        public static lab18 Instance;


        public lab18()
        {
            Instance = this;

            InitializeComponent();
            buttonProdBetween.Enabled = false;
            button_find_max_index.Enabled = false;
            buttonTransform.Enabled = false;

            buttonDiff.Enabled = false;
            buttonGeomMean.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            print("Generated array: " + Task1.get_random_array(Convert.ToInt16(arraySizeInput.Value)));
        //enable buttons after generating an array
            if (Task1.arr != null)
            {
                buttonProdBetween.Enabled = true;
                button_find_max_index.Enabled = true;
                buttonTransform.Enabled = true;
            }
        }

        private void button_find_max_index_Click(object sender, EventArgs e)
        {
            print("Max number is at index: " + Task1.FindMaxIndex(Task1.arr));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonProdBetween_Click(object sender, EventArgs e)
        {
            Task1.ProductBetweenZeros(Task1.arr);
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {
            print("Transformed array: " + Task1.get_transformed_array());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenMatrix_Click(object sender, EventArgs e)
        {
            Task2.generate_matrix(Convert.ToInt16(arraySizeY.Value), Convert.ToInt16(arraySizeX.Value));
            Task2.PrintMatrix(Task2.matrix, Convert.ToInt16(arraySizeY.Value), Convert.ToInt16(arraySizeX.Value));
            if (Task2.matrix != null)
            {
                buttonDiff.Enabled = true;
                buttonGeomMean.Enabled = true;
            }
        }

        private void buttonGeomMean_Click(object sender, EventArgs e)
        {
            Task2.get_geom_mean();
        }

        private void buttonDiff_Click(object sender, EventArgs e)
        {
            Task2.get_diff();
        }

        private void consoleBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void print(string text,bool newline = true)
        {
            if (newline)
            {
                consoleTextBox.AppendText(text + "\n");
            }
            else
            {
                consoleTextBox.AppendText(text);
            }
        }

        private void lab18_Load(object sender, EventArgs e)
        {

        }
    }
}
