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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.14;
            double a, b, c;
            double x = double.Parse(textBox1.Text);//diametr

            a = x / 2;//r
            c = 1.33;
            b = c * pi * Math.Pow(a, 3);

            label3.Text = b.ToString();
            


        




        }
    }
}
