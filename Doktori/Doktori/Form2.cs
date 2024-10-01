using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doktori
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 forma3 = new Form3();
            forma3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 forma4 = new Form4();
            forma4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 forma5 = new Form5();
            forma5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 forma6 = new Form6();
            forma6.Show();
        }
    }
}
