using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(textBox5.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                textBox6.Text = "Total= " + c.ToString();

            }
            if (radioButton2.Checked)
            {
                c = a * b;
                textBox6.Text = "Total= " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a / b;
                textBox6.Text = "Total= " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a - b;
                textBox6.Text = "Total= " + c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                textBox6.Text = "Total= " + c.ToString();
            }
           
            }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

    }

}
        
    