using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismApp
{
    public partial class Hassan : Form
    {
        public Hassan()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ha1 ha1 = new Ha1();
            ha1.Show(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Ha2 ha2 = new Ha2();
            ha2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ha3 ha3 = new Ha3();
            ha3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ha4 ha4 = new Ha4();
            ha4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Ha5 ha5 = new Ha5();
            ha5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Ha6 ha6 = new Ha6();
            ha6.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Ha7 ha7 = new Ha7();
            ha7.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Ha8 ha8 = new Ha8();
            ha8.Show();
        }
    }
}
