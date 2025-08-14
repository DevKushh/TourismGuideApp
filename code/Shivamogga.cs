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
    public partial class Shivamogga : Form
    {
        public Shivamogga()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sh1 sh1 = new Sh1();
            sh1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Sh2 sh2 = new Sh2();
            sh2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Sh3 sh3 = new Sh3();
            sh3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Sh4 sh4 = new Sh4();
            sh4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Sh5 sh5 = new Sh5();
            sh5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Sh6 sh6 = new Sh6();
            sh6.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Sh7 sh7 = new Sh7();
            sh7.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Sh8 sh8 = new Sh8();
            sh8.Show();
        }
    }
}
