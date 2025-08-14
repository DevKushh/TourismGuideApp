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
    public partial class Sh3 : Form
    {
        public Sh3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://maps.app.goo.gl/ANvXKttptUGbvrsm9");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kn.m.wikipedia.org/wiki/%E0%B2%B8%E0%B2%95%E0%B3%8D%E0%B2%95%E0%B2%B0%E0%B3%86%E0%B2%AC%E0%B3%88%E0%B2%B2%E0%B3%81");

        }
    }
}
