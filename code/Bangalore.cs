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
    public partial class Bangalore : Form
    {
        public Bangalore()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Ba8 ba8 = new Ba8();
            ba8.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Ba5 ba5 = new Ba5();
            ba5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ba1 ba1 = new Ba1();
            ba1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Ba2 ba2 = new Ba2();
            ba2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ba3 ba3 = new Ba3();
            ba3.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ba4 ba4 = new Ba4();
            ba4.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Ba6 ba6 = new Ba6();
            ba6.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Ba7 ba7 = new Ba7();
            ba7.Show();
        }
    }
}
