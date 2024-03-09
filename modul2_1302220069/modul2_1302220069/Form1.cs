using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace modul2_1302220069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text+"1";
            if (textBox4.Text!="true")
            {
                textBox2.Text=textBox2.Text+"1";
            }
            else
            {
                textBox3.Text=textBox3.Text+"1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            if (textBox4.Text != "true")
            {
                textBox2.Text = textBox2.Text + "2";
            }
            else
            {
                textBox3.Text = textBox3.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            if (textBox4.Text != "true")
            {
                textBox2.Text = textBox2.Text + "3";
            }
            else
            {
                textBox3.Text = textBox3.Text + "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)//4
        {
            textBox1.Text = textBox1.Text + "4";
            if (textBox4.Text != "true")
            {
                textBox2.Text = textBox2.Text + "4";
            }
            else
            {
                textBox3.Text = textBox3.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            if (textBox4.Text != "true")
            {
                textBox2.Text = textBox2.Text + "5";
            }
            else
            {
                textBox3.Text = textBox3.Text + "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)//6
        {
            textBox1.Text = textBox1.Text + "6";
            if (textBox4.Text != "true")
            {
                textBox2.Text = textBox2.Text + "6";
            }
            else
            {
                textBox3.Text = textBox3.Text + "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)//7
        {
            textBox1.Text = textBox1.Text + "7";
            if (textBox4.Text != "true")
            {
                textBox2.Text = textBox2.Text + "7";
            }
            else
            {
                textBox3.Text = textBox3.Text + "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)//8
        {
            textBox1.Text = textBox1.Text + "8";
            if (textBox4.Text != "true")
            {
                textBox2.Text = textBox2.Text + "8";
            }
            else
            {
                textBox3.Text = textBox3.Text + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)//9
        {
            textBox1.Text = textBox1.Text + "9";
            if (textBox4.Text != "true")
            {
                textBox2.Text = textBox2.Text + "9";
            }
            else
            {
                textBox3.Text = textBox3.Text + "9";
            }
        }

        private void button9_Click(object sender, EventArgs e)//+
        {
            if (textBox4.Text != "true"){
                textBox4.Text = "true";
                textBox1.Text = textBox1.Text + "+";
            }
            else
            {
                if (textBox3.Text != "")
                {
                    textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text));
                }
                else
                {
                    textBox1.Text = textBox1.Text + "+";
                }
                textBox3.Text = "";
                textBox1.Text = textBox2.Text+"+";
            }
        }

        private void button8_Click(object sender, EventArgs e)//0
        {
            textBox1.Text = textBox1.Text + "0";
            if (textBox4.Text != "true")
            {
                textBox2.Text = textBox2.Text + "0";
            }
            else
            {
                textBox3.Text = textBox3.Text + "0";
            }
        }

        private void button7_Click(object sender, EventArgs e)//=
        {
            if (textBox4.Text != "true")
            {
                textBox1.Text = textBox2.Text;
            }
            else
            {
                if (textBox3.Text != "")
                {
                    textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text));
                    textBox1.Text = textBox2.Text;
                }
                else
                {
                    textBox1.Text = textBox2.Text;
                }
                textBox3.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
