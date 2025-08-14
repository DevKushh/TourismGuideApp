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
    public partial class Hubli : Form
    {
        public Hubli()
        {
            InitializeComponent();
        }
       
        private void Hubli_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Hu1 hu1 = new Hu1();
            hu1.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Hu2 hu2 = new Hu2();
            hu2.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Hu3 hu3 = new Hu3();
            hu3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hu4 hu4 = new Hu4();
            hu4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hu5 hu5 = new Hu5();
            hu5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Hu6 hu6 = new Hu6();
            hu6.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Hu7 hu7 = new Hu7();
            hu7.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Hu8 hu8 = new Hu8();
            hu8.Show();
        }
    }
}
