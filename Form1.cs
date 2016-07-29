using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecHexBin
{
    public partial class Form1 : Form
    {
        ulong number;
        string number2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    number = Convert.ToUInt64(textBox1.Text);
                    textBox2.Text = Convert.ToString(Conversor.decimalToBinary(number));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Não é um numero");
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Número Não Aceito");
                }
            }
            else
            {
                try
                {
                    number2 = textBox2.Text;
                    textBox1.Text = Convert.ToString(Conversor.binaryToDecimal(number2));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Não é um binario");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    number = Convert.ToUInt64(textBox1.Text);
                    textBox3.Text = Conversor.decimalToHexadecimal(number);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Não é um numero");
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Número Não Aceito");
                }
            }
            else
            {
                try
                {
                    number2 = textBox3.Text;
                    textBox1.Text = Convert.ToString(Conversor.hexadecimalToDecimal(number2));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Não é um binario");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    number2 = textBox2.Text;
                    number = Conversor.binaryToDecimal(number2);
                    textBox3.Text = Convert.ToString(Conversor.decimalToHexadecimal(number));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Não é um numero");
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Número Não Aceito");
                }
            }
            else
            {
                try
                {
                    number2 = textBox3.Text;
                    number = Conversor.hexadecimalToDecimal(number2);
                    textBox2.Text = Conversor.decimalToBinary(number);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Não é um binario");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        
    }
}
