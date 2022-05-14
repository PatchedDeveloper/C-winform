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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 window = new Form2();
            window.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 window = new Form3();
            window.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 window = new Form4();
            window.ShowDialog();
        }
    }
}
