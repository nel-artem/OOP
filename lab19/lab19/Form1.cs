using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab19
{
    public partial class Form1 : Form
    {

        string wrongCode = @"function greet(name {
            if (name.length > 0) {
                console.log(""Hello, "" + name);

                for (let i = 0; i < 3; i++) {
                    console.log(i);
                ]

            } else {
                console.log(""No name provided"");
            }

        }

        greet(""Alice"");
        ";

        string rightCode = @"function greet(name) {
            if (name.length > 0) {
                console.log(""Hello, "" + name);

                for (let i = 0; i < 3; i++) {
                   console.log(i);
                }   
             } else {
                console.log(""No name provided"");
             }
        }

        greet(""Alice"");
        ";

        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string expression = codeBox.Text;

            if (string.IsNullOrWhiteSpace(expression))
            {
                resultLabel.Text = "Enter an expression to check.";
                resultLabel.ForeColor = Color.Gray;
                return;
            }

            var opens = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            var closes = new HashSet<char> { ')', ']', '}' };
            var stack = new Stack<(char ch, int index)>();
            string error = null;

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (opens.ContainsKey(ch))
                {
                    stack.Push((ch, i));
                }
                else if (closes.Contains(ch))
                {
                    if (stack.Count == 0)
                    {
                        error = $"Extra closing bracket '{ch}' at position {i + 1}";
                        break;
                    }

                    var (top, _) = stack.Pop();

                    if (opens[top] != ch)
                    {
                        error = $"Expected '{opens[top]}' but found '{ch}' at position {i + 1}";
                        break;
                    }
                }
            }

            if (error == null && stack.Count > 0)
            {
                var (unclosed, pos) = stack.Peek();
                error = $"Unclosed bracket '{unclosed}' at position {pos + 1}";
            }

            if (error == null)
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = "Brackets are valid.";
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = error;
            }
        }

        private void correctCodeButton_Click(object sender, EventArgs e)
        {
            codeBox.Text = rightCode;
        }

        private void incorrectCodeButton_Click(object sender, EventArgs e)
        {
            codeBox.Text = wrongCode;

        }
    }
}
