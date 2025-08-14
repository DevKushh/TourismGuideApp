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
    public partial class Mysore : Form
    {
        public Mysore()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            My1 my1 = new My1();
            my1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            My2 my2 = new My2();
            my2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            My3 my3 = new My3();
            my3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            My4 my4 = new My4();
            my4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            My5 my5 = new My5();
            my5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            My6 my6 = new My6();
            my6.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            My7 my7 = new My7();
            my7.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            My8 my8 = new My8();
            my8.Show();
        }
    }
}
