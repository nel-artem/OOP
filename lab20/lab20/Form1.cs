using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsPalindrome(string input)
        {
            string cleaned = input.ToLower().Replace(" ", "");
            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = palindromeText.Text;

                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("Input something first.");

                bool isPalindrome = IsPalindrome(input);

                resultLabel.ForeColor = isPalindrome ? Color.Green : Color.Red;
                resultLabel.Text = isPalindrome
                    ? $"\"{input}\" is a palindrome."
                    : $"\"{input}\" is not a palindrome.";
            }
            catch (ArgumentException ex)
            {
                resultLabel.ForeColor = Color.Gray;
                resultLabel.Text = ex.Message;
            }
            catch (Exception ex)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = "exception: " + ex.Message;
            }
            finally
            {
                palindromeText.Focus();
            }
        }
    }
}
