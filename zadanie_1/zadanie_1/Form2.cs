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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void form1_load()
        {
            textBox1.Text = "Введите значение";
            textBox2.Text = "Введите значение";
            textBox3.Text = "Введите значение";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double d;
            double x = double.Parse(textBox1.Text);//read
            textBox4.Text += Environment.NewLine +  "x = " + x.ToString();//enter to textbox4
            double y = double.Parse(textBox1.Text);//read
            textBox4.Text += Environment.NewLine + "y = " + y.ToString();//enter to textbox4
            double z = double.Parse(textBox1.Text);//read
            textBox4.Text += Environment.NewLine + "z = " + z.ToString();//enter to textbox4

            a = Math.Tan(x + y) * Math.Tan(x + y);
            b = Math.Exp(y - z);
            c = Math.Sqrt(Math.Cos(x * x) + Math.Sin(z * z));
            d = a - b * c;

            textBox4.Text += Environment.NewLine + " Результат U= " + d.ToString();

        }
    }
}
