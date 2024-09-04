using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp323
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == textBox2.Text)
            {
                double a = Convert.ToDouble(textBox2.Text), b = Convert.ToDouble(textBox3.Text), c = a + b;
                textBox4.Text = c.ToString();
            }
            else
            {
                double a = Convert.ToDouble(textBox2.Text), b = Convert.ToDouble(textBox3.Text), c = a - b;
                textBox4.Text = c.ToString();
            }
        }
    }
}
