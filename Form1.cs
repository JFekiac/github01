using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace github01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int soucet = a + b;
            MessageBox.Show("Soucet: " + soucet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int rozdil = a - b;
            MessageBox.Show("Soucet: " + rozdil);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int soucin = a * b;
            MessageBox.Show("Soucet: " + soucin);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int podil = a / b;
            MessageBox.Show("Soucet: " + podil);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int soucet = a + b;           
            int rozdil = a - b;
            int soucin = a * b;
            int podil = a / b;
            MessageBox.Show("Soucet: " + soucet + "\nRozdil: " + rozdil + "\nSoucin: " + soucin + "\nPodil: " + podil);
        }
    }
}
