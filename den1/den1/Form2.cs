using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace den1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z,f;

            z = double.Parse(textBox3.Text);

            if (radioButton1.Checked)
            {
                f = Math.Sin(z);
                textBox3.Text = f.ToString();
            }
            else if (radioButton2.Checked)
            {
                f = Math.Cos(z);
                textBox3.Text = f.ToString();
            }
            else if (radioButton3.Checked)
            {
                f = Math.Sqrt(z);
                textBox3.Text = f.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a;
            double x = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            if (radioButton4.Checked)
            {
                a = x + b;
                textBox3.Text = a.ToString();
            }
            else if(radioButton5.Checked)
            {
                a = x - b;
                textBox3.Text = a.ToString();
            }
            else if (radioButton6.Checked)
            {
                a = x * b;
                textBox3.Text = a.ToString();
            }
            else if (radioButton7.Checked)
            {
                a = x / b;
                textBox3.Text = a.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
