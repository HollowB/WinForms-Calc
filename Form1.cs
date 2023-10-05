using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += zero.Text;
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text += one.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += two.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += three.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += four.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += five.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += six.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += seven.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += eight.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += nine.Text;
        }

        private void openBracket_Click(object sender, EventArgs e)
        {
            textBox1.Text += openBracket.Text;
        }

        private void closeBracket_Click(object sender, EventArgs e)
        {
            textBox1.Text += closeBracket.Text;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += plus.Text;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += minus.Text;
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            textBox1.Text += multiple.Text;
        }

        private void division_Click(object sender, EventArgs e)
        {
            textBox1.Text += division.Text;
        }

        private void pow_Click(object sender, EventArgs e)
        {
            textBox1.Text += pow.Text;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            string result = Convert.ToString(PRNCalc.Calculate(textBox1.Text));
            textBox1.Text = result;
        }
    }
}
