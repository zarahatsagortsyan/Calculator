using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        double number1;
        double number2;
        bool tzro = false;
        string c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            tzro = false;
            Button bt = (Button)sender;

            string s = textBox1.Text;

            if (s[0] == '0' && s.Count() == 1)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + bt.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + bt.Text;
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (tzro != true && textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text + button_0.Text;
            }
            else
            {
                tzro = true;
            }
        }

        private void button_ket_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            number1 = 0;
            textBox1.Text = number1.ToString();
        }

        private void button_het_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            textBox1.Text = "";
            if (s.Count() == 1)
            {
                textBox1.Text = "0";
            }
            else
                for (int i = 0; i < s.Count() - 1; i++)
                {
                    textBox1.Text += s[i];
                }
        }

        private void button_armat_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Sqrt(number2).ToString();
        }

        private void button_qarakusi_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Pow(number2, 2).ToString();
        }

        private void button_1_2_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            number2 = 1 / number2;
            textBox1.Text = number2.ToString();
        }

        private void button_havasar_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);

            switch (c)
            {
                case "+":
                    textBox1.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    textBox1.Text = (number1 - number2).ToString();
                    break;
                case "×":
                    textBox1.Text = (number1 * number2).ToString();
                    break;
                case "÷":
                    textBox1.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void button_plus_minus_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            number2 *= -1;
            textBox1.Text = number2.ToString();
        }

        private void button_tokos_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (number1 * number2 / 100).ToString();
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            if (number2 > 0)
            {
                textBox1.Text = "0";
            }
        }
        private void button_gumarum_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            number1 = Convert.ToDouble(textBox1.Text);
            c = bt.Text;
            textBox1.Text = "0";
        }
    }
}