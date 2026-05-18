using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    internal class Task2
    {
        public static double[,] matrix;
        public static int r1 = 0, c1 = 1;
        public static int r2 = 2, c2 = 3;


        public static void generate_matrix(int rows, int cols)
        {
            matrix = GenerateMatrix(rows, cols);

        }

        public static void get_diff()
        {
            double diff = Difference(matrix, r1, c1, r2, c2);
            lab18.Instance.print($"\nA[{r1},{c1}] - A[{r2},{c2}] = {matrix[r1, c1]} - {matrix[r2, c2]} = {diff}");
        }

        public static void get_geom_mean()
        {
            double geo = GeometricMean(matrix, r1, c1, r2, c2);
            if (!double.IsNaN(geo))
                lab18.Instance.print($"Geometric mean A[{r1},{c1}] і A[{r2},{c2}] = {geo:F4}");
            else
                lab18.Instance.print("The geometric mean is undefined");
        }

        public static double[,] GenerateMatrix(int rows, int cols)
        {
            var rnd = new Random();
            var m = new double[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    m[i, j] = Math.Round(rnd.NextDouble() * 20 - 10, 1);
            return m;
        }

        public static double Difference(double[,] m, int r1, int c1, int r2, int c2)
        {
            return m[r1, c1] - m[r2, c2];
        }

        public static double GeometricMean(double[,] m, int r1, int c1, int r2, int c2)
        {
            double a = m[r1, c1], b = m[r2, c2];
            if (a * b < 0) return double.NaN;
            return Math.Sqrt(Math.Abs(a * b));
        }


        public static void PrintMatrix(double[,] m, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    lab18.Instance.print($"{m[i, j],7:F1}",false);
                lab18.Instance.print("");
            }
        }


    }
}
