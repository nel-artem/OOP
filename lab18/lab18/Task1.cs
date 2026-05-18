using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    internal class Task1
    {
        public static double[] arr;

        public static string get_random_array(int size = 12)
        {
            int n = size;
            arr = GenerateArray(n);
            return PrintArray(arr);
            

        }

        public static string get_transformed_array()
        {
            return PrintArray(TransformArray(arr));
        }

        public static string PrintArray(double[] arr)
        {
            return "[" + string.Join("|", Array.ConvertAll(arr, x => $"{x,5}")) + "]";
        }

        public static double[] GenerateArray(int n)
        {
            var rnd = new Random();
            var arr = new double[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(5) == 0 ? 0 : Math.Round(rnd.NextDouble() * 20 - 10, 1);
            return arr;
        }

        public static int FindMaxIndex(double[] arr)
        {
            int maxIdx = 0;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > arr[maxIdx])
                    maxIdx = i;
            return maxIdx;
        }

        public static double ProductBetweenZeros(double[] arr)
        {
            int first = -1, second = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    if (first == -1) first = i;
                    else { second = i; break; }
                }
            }

            if (first == -1 || second == -1)
            {
                lab18.Instance.print("Array doesnt have two zeros.");
                return double.NaN;
            }

            if (second - first == 1)
            {
                lab18.Instance.print("No elements between two zeros.");
                return double.NaN;
            }

            double product = 1;
            lab18.Instance.print("Elements between zeros: ");
            for (int i = first + 1; i < second; i++)
            {
                product *= arr[i];
                lab18.Instance.print($"{arr[i]} ");
            }
            lab18.Instance.print($"\nProduct = {product}");
            return product;
        }

        public static double[] TransformArray(double[] arr)
        {
            var result = new double[arr.Length];
            int pos = 0;

            for (int i = 0; i < arr.Length; i += 2) // непарні позиції (1, 3, 5...)
                result[pos++] = arr[i];

            for (int i = 1; i < arr.Length; i += 2) // парні позиції (2, 4, 6...)
                result[pos++] = arr[i];

            return result;
        }

    }
}
