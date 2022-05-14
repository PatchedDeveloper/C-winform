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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox4.Checked==true) && ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false)))
            {
                label1.Text = "ПРАВИЛЬНО!";
            }
            else
                label1.Text = "ОШИБКА!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true) && ((radioButton2.Checked == false) && (radioButton3.Checked == false) && (radioButton1.Checked == false)))
            {
                label4.Text = "ПРАВИЛЬНО!";
            }
            else
                label4.Text = "ОШИБКА!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "класса" || textBox1.Text == "Класса")
            {
                label6.Text = "Верно";
            }
            else
                label6.Text = "не верно";
        }
    }
}
