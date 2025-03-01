using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGibHubAnhTuyenNhom2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(6);
            int b = rnd.Next(6);
            int c = rnd.Next(6);
            int d = rnd.Next(255);
            int r = rnd.Next(255);
            int f = rnd.Next(255);
            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();
            if(a+b+c <= 6)
            {
                label4.Text = "Xiu";
            }
            else
            {
                label4.Text = "Tai";
            }
            label4.BackColor = Color.FromArgb(d, r, f);
        }
    }
}
