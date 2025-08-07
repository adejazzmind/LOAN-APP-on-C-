using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOANAPP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            double AMOUNT = int.Parse(textBox1.Text);
            double DURATION = int.Parse(textBox2.Text);
            double INTEREST = AMOUNT * 0.1;
            double PAYMENT = (AMOUNT + INTEREST) / DURATION;
            label3.Text = PAYMENT.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
