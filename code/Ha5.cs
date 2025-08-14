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
    public partial class Ha5 : Form
    {
        public Ha5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://maps.app.goo.gl/Sn1a6iuwaV5wu8jU6");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kn.m.wikipedia.org/wiki/%E0%B2%B9%E0%B3%87%E0%B2%AE%E0%B2%BE%E0%B2%B5%E0%B2%A4%E0%B2%BF_%E0%B2%9C%E0%B2%B2%E0%B2%BE%E0%B2%B6%E0%B2%AF");

        }
    }
}
