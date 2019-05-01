using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            double KhUsed, charge; //khw Used & charge

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (KhUsed > 2000) //KhUsed > 2000 ---> message box show
            {
                e.Cancel = true;
                MessageBox.Show("KHW cannot exceed 2000");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhUsed = double.Parse(textBox1.Text);
            if (KhUsed > 2000) //KhUsed > 2000 ---> message box show
            {
                MessageBox.Show("KHW cannot exceed 2000");
            }

            if (KhUsed <= 100)
            {
                charge = KhUsed * .35; // khUsed * .35 cents
            }
            else if (KhUsed <= 200)
            {
                charge = 35 + (KhUsed - 100) * .45; // i.e 35 + (200-100) * 45 = 80
            }
            else if (KhUsed < 500)
            {
                charge = 80 + (KhUsed - 300) * .65;
            }
            else if (KhUsed <= 2000)
            {
                charge = 275 + (KhUsed - 500) * .80;
            }
            textBox2.Text = charge.ToString();
        }
    }
}
