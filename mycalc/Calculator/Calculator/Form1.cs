using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string number1="", number2="",islem="";
            string text = textBox1.Text;
            for (int i=0; i<=text.Length-1;i++)
            {
                if (i==0) // x / - + may only - 
                {
                    number1 += text[i];
                }
                else
                {
                    if (text[i] != 'x' && text[i] != '+' && text[i] != '-' && text[i] != '/')
                    {
                        number1 += text[i];

                    }
                    if (text[i] == 'x') { islem = "carpma"; break; }
                    if (text[i] == '/') { islem = "bolme"; break; }
                    if (text[i] == '-') { islem = "cıkarma"; break; }
                    if (text[i] == '+') { islem = "toplama"; break; }
                }
            }
            for (int i=text.Length-1; i>=0; i--)
            {
                if (text[i] != 'x' && text[i] != '+' && text[i] != '-' && text[i] != '/')
                {
                    number2 += text[i];
                }
                else
                {
                    string number3="";
                    for (i = number2.Length-1 ; i >=0; i--)
                    {
                        number3 += number2[i];
                    }
                    number2= number3;
                    break;
                }
            }
            switch (islem)
            {
                case "carpma":
                    float number11 = float.Parse(number1);
                    float number12 = float.Parse(number2);
                    float multiplication = number11 * number12;
                    textBox1.Text = multiplication.ToString();
                    break;
                case "bolme":
                    float number21 = float.Parse(number1);
                    float number22 = float.Parse(number2);
                    float division = number21 / number22;
                    textBox1.Text = division.ToString();
                    break;
                case "cıkarma":
                    //codes
                    float number31 = float.Parse(number1);
                    float number32 = float.Parse(number2);
                    float extraction = number31 - number32;
                    textBox1.Text = extraction.ToString();
                    break;
                case "toplama":
                    //codes
                    float number41 = float.Parse(number1);
                    float number42 = float.Parse(number2);
                    float sum = number41 + number42;
                    textBox1.Text = sum.ToString();
                    break;
            }
        }

        private void butx_Click(object sender, EventArgs e)
        {
            textBox1.Text += "x";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }
    }
}
