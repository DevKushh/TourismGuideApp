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
    public partial class Mangalore : Form
    {
        public Mangalore()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ma1 ma1 = new Ma1 ();
            ma1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Ma2 ma2 = new Ma2 ();
            ma2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ma3 ma3 = new Ma3 ();
            ma3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ma4 ma4 = new Ma4 ();
            ma4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Ma5 ma5 = new Ma5 ();
            ma5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Ma6 ma6 = new Ma6 ();
            ma6.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Ma7 ma7 = new Ma7 ();
            ma7.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Ma8 ma8 = new Ma8();
            ma8.Show();
        }
    }
}
