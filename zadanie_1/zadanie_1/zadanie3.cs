using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_1
{
    public partial class zadanie3 : Form
    {
        public zadanie3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b,c;
            double n = double.Parse(textBox1.Text);
            double n_ct = double.Parse(textBox2.Text);
            double n_sim = double.Parse(textBox3.Text);


            a = n * n_ct * n_sim;// общее колличество страниц
            b = a / (8*1024);//килобайт
            c = b / 1024;//мегабайт

            textBox4.Text += Environment.NewLine + "Килобайт " + b.ToString();
            textBox4.Text += Environment.NewLine + "Мегабайт " + c.ToString();

        }
    }
}
