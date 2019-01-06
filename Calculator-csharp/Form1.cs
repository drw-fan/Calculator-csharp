using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_csharp
{
    public partial class Calculator : Form
    {
        decimal answer = 0m;
        decimal num1 = 0, num2 = 0;
        char operation = 'c';
        string resultString = "";
        bool positive = true;
 
        public Calculator()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            answer = 0m;
            num1 = 0m;
            operation = 'c';
            resultLabel.Text = "0";
            resultString = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            operation = '/';
            num1 = decimal.Parse(resultLabel.Text);
            resultString = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            operation = '*';
            num1 = decimal.Parse(resultLabel.Text);
            resultString = "";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if ((operation == '+') || (operation == '-'))
            {
                if (operation == '+')
                    answer = decimal.Parse(resultLabel.Text) + num1;
                else
                    answer = num1 - decimal.Parse(resultLabel.Text);

                resultLabel.Text = answer.ToString("#,#.###############");
                num1 = answer;
            }
            else
            {
                num1 = decimal.Parse(resultLabel.Text);
            }

            operation = '-';
            resultString = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((operation == '+') || (operation == '-'))
            {
                if (operation == '+')
                    answer = decimal.Parse(resultLabel.Text) + num1;
                else
                    answer = num1 - decimal.Parse(resultLabel.Text);

                resultLabel.Text = answer.ToString("#,#.###############");
                num1 = answer;
            }
            else
            {
                num1 = decimal.Parse(resultLabel.Text);
            }

            operation = '+';
            resultString = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(resultLabel.Text);

            if (operation == '+')
                answer = num1 + num2;
            else if (operation == '-')
                answer = num1 - num2;
            else if (operation == '*')
                answer = num1 * num2;
            else if (operation == '/')
                answer = num1 / num2;

            if (answer == 0)
                resultString = "0";
            else resultString = answer.ToString("#,#.###############");

            resultLabel.Text = resultString;
            operation = 'c';
            resultString = "";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (resultString != "")
            {
                if (resultLabel.Text != "0")
                {
                    resultString = resultString + "0";
                    resultLabel.Text = resultString;
                }
                else
                    resultLabel.Text = "0";
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
           resultString = resultString + "1";
           resultLabel.Text = resultString;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            resultString = resultString + "2";
            resultLabel.Text = resultString;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            resultString = resultString + "3";
            resultLabel.Text = resultString;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            resultString = resultString + "4";
            resultLabel.Text = resultString;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            resultString = resultString + "5";
            resultLabel.Text = resultString;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            resultString = resultString + "6";
            resultLabel.Text = resultString;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            resultString = resultString + "7";
            resultLabel.Text = resultString;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            resultString = resultString + "8";
            resultLabel.Text = resultString;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            resultString = resultString + "9";
            resultLabel.Text = resultString;
        }

        private void decimalPointButton_Click(object sender, EventArgs e)
        {
            resultString = resultString + ".";
            resultLabel.Text = resultString;
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            resultString = resultLabel.Text;

            if (char.IsDigit(resultString, 0))
                resultString = "-" + resultString;
            else
                resultString = resultString.Substring(1);

            resultLabel.Text = resultString;
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (decimal.Parse(resultLabel.Text) * (decimal).01).ToString("#,0.00");
            resultString = resultLabel.Text;
        }
    }
}
