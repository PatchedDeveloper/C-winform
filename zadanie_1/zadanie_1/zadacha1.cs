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
    public partial class zadacha1 : Form
    {
        public zadacha1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.14;
            double z;
            double x = double.Parse(textBox1.Text);//read

            z = pi * Math.Pow(x / 2, 2);

            label3.Text = z.ToString();
        }
    }
}
