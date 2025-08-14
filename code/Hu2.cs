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
    public partial class Hu2 : Form
    {
        public Hu2()
        {
            InitializeComponent();
        }

        private void Hu2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://maps.app.goo.gl/88HjxHUfMJowx9pg7");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.m.wikipedia.org/wiki/File:Bhavani_shankar_temple_old-Hubli_Karnataka_1.jpg");

        }
    }
}
