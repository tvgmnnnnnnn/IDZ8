using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iz8_opp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            int n = int.Parse(textBox1.Text);
            int r = int.Parse(textBox2.Text);
            if (radioButton1.Checked)
            {
                textBox5.Text = Уравнение.Уравнение1(x, n, r).ToString();
            }
            else
            {
                textBox5.Text = Уравнение.Уравнение2(n, r).ToString();
            }
        }
    }
}
