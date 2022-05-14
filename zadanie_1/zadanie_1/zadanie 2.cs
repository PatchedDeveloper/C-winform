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
    public partial class zadanie_2 : Form
    {
        public zadanie_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double x = double.Parse(textBox1.Text);
            textBox2.Text += Environment.NewLine + "x = " + x.ToString();

            a = x / 8;//byte
            b = a / 1024; //kilobite
            c = b / 1024;// megabyte

            textBox2.Text += Environment.NewLine + "байт = " + a.ToString();
            textBox2.Text += Environment.NewLine + "Килобайт = " + b.ToString();
            textBox2.Text += Environment.NewLine + "Мегабайт = " + c.ToString();
        }
    }
}
