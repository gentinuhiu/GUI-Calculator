using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLeftBracket_Click(object sender, EventArgs e)
        {
            String txt = input.Text;
            char c = txt[txt.Length - 1];

            if (txt == "0")
            {
                input.Text = "(";
            }
            else if (txt.Length > 0 && (!char.IsDigit(c) && c != '.' && c != ')'))
            {
                input.Text += "(";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            char c = input.Text[input.Text.Length - 1];

            if (c != '.' && c != '+' && c != '-' && c != '*' && c != '/' && c != '(')
            {
                input.Text += '/';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(input.Text != "0" && (input.Text[input.Text.Length - 1] != ')'))
            {
                input.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "1";
            }
            else if (input.Text[input.Text.Length - 1] != ')')
            {
                input.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "2";
            }
            else if (input.Text[input.Text.Length - 1] != ')')
            {
                input.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "3";
            }
            else if (input.Text[input.Text.Length - 1] != ')')
            {
                input.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "4";
            }
            else if (input.Text[input.Text.Length - 1] != ')')
            {
                input.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "5";
            }
            else if (input.Text[input.Text.Length - 1] != ')')
            {
                input.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "6";
            }
            else if (input.Text[input.Text.Length - 1] != ')')
            {
                input.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "7";
            }
            else if (input.Text[input.Text.Length - 1] != ')')
            {
                input.Text += "7";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "9";
            }
            else if (input.Text[input.Text.Length - 1] != ')')
            {
                input.Text += "9";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "8";
            }
            else if (input.Text[input.Text.Length - 1] != ')')
            {
                input.Text += "8";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            input.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            String txt = input.Text;
            if(txt == "0")
            {
                input.Text += ".";
            }
            else if(txt != "0" && char.IsDigit(txt[txt.Length - 1]))
            {
                for(int i = txt.Length - 1; i >= 0; i--)
                {
                    if (txt[i] == '.')
                    {
                        return;
                    }
                    if (!char.IsDigit(txt[i]))
                    {
                        break;
                    }
                }
                input.Text += ".";
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btnRightBracket_Click(object sender, EventArgs e)
        {
            char c = input.Text[input.Text.Length - 1];
            if (!char.IsDigit(c) && c != ')')
            {
                return;
            }

            int left_brackets = 0;
            int right_brackets = 0;

            for(int i = 0; i < input.Text.Length; i++)
            {
                if (input.Text[i] == '(')
                {
                    left_brackets++;
                }
                else if (input.Text[i] == ')')
                {
                    right_brackets++;
                }
            }
            if(left_brackets == right_brackets)
            {
                return;
            }
            input.Text += ")";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            char c = input.Text[input.Text.Length - 1];

            if(c != '.' && c != '+' && c != '-' && c != '*' && c != '/')
            {
                input.Text += '+';
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            char c = input.Text[input.Text.Length - 1];

            if(c == '0' && input.Text.Length == 1)
            {
                input.Text = "-";
                return;
            }

            if (c != '.' && c != '+' && c != '-' && c != '*' && c != '/')
            {
                input.Text += '-';
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            char c = input.Text[input.Text.Length - 1];

            if (c != '.' && c != '+' && c != '-' && c != '*' && c != '/' && c != '(')
            {
                input.Text += '*';
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            String txt = input.Text;
            char c = txt[txt.Length - 1];

            if(txt.Length <= 1)
            {
                return;
            }
            foreach(char tmp in txt)
            {
                if(!char.IsDigit(tmp) && tmp != '.' && tmp != '+' && tmp != '-' && tmp != '*' && tmp != '/' && tmp != '(' && tmp != ')')
                {
                    input.Text = "0";
                    return;
                }
            }
            

            if(c == '.' || c == '+' || c == '-' || c == '*' || c == '/')
            {
                input.Text = "Error: Last Character";
                return;
            }

            int left_brackets = 0;
            int right_brackets = 0;

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '(')
                {
                    left_brackets++;
                }
                else if (txt[i] == ')')
                {
                    right_brackets++;
                }
            }

            if(left_brackets != right_brackets)
            {
                input.Text = "Error: Missing Bracket";
                return;
            }

            string result = Equation.calculate(input.Text);
            input.Text = result;
        }
    }
    public static class Equation
    {
        public static string calculate(string line)
        {
            int index = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (c == '(')
                {
                    index = i;
                }
                else if (c == ')')
                {
                    string equationLine = line.Substring(index, i - index + 1);
                    string result = Operation.calculate(equationLine.Substring(1, equationLine.Length - 2));

                    if (result == "Division by 0")
                    {
                        return result;
                    }

                    line = line.Replace(equationLine, result);
                    i = 0;
                    index = 0;
                }
            }

            return Operation.calculate(line);
        }
    }

    public static class Operation
    {
        public static string calculate(string line)
        {
            List<double> numbers = new List<double>();
            List<char> signs = new List<char>();
            int index = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (!char.IsDigit(c))
                {
                    if (((i == 0) && (c == '+' || c == '-')) || (c == '.'))
                    {
                        continue;
                    }


                    if (char.IsDigit(line[i - 1]))
                    {
                        if (index > 0 && line[index - 1] == '-')
                        {
                            index++;
                        }
                        numbers.Add(Convert.ToDouble(line.Substring(index, i - index)));
                        signs.Add(c);
                    }

                    index = i;
                    if (c == '*' || c == '/')
                    {
                        index++;
                    }
                }
            }
            if (index > 0 && line[index - 1] == '-')
            {
                index++;
            }

            string equationLine = line.Substring(index, line.Length - index); 
            double tmp = Convert.ToDouble(equationLine);
            numbers.Add(tmp);

            bool flag = Operation.mul_div(numbers, signs);
            if(!flag)
            {
                return "Division by 0";
            }

            double result = 0;
            foreach (double number in numbers)
            {
                result += number;
            }

            return result.ToString();
        }
        private static bool mul_div(List<Double> numbers, List<char> signs)
        {
            int i = 0;
            while (i < signs.Count)
            {
                char c = signs[i];
                if (c == '*' || c == '/')
                {
                    Double x = numbers[i];
                    Double y = numbers[i + 1];

                    double result = -999;
                    if (c == '*')
                    {
                        result = x * y;
                    }
                    else if (c == '/')
                    {
                        if(y == 0)
                        {
                            return false;
                        }

                        result = x / y;
                    }

                    numbers[i + 1] = result;
                    numbers.RemoveAt(i);
                    signs.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            return true;
        }
    }
}
