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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Text = "Первый флажок работет";
            }
            if (checkBox2.Checked)
            {
                label1.Text = "второй флажок работет";
            }
            if (checkBox1.Checked && checkBox1.Checked)
            {
                label1.Text = "оба флажка работают";
            }
        }
    }
}
