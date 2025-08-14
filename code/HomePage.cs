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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Bangalore bangalore = new Bangalore();
            bangalore.Show();
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Hubli hubli = new Hubli();
            hubli.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Mysore mysore = new Mysore();   
            mysore.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Mangalore mangalore = new Mangalore();
            mangalore.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Shivamogga shivamogga = new Shivamogga();
            shivamogga.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Hassan hassan = new Hassan();
            hassan.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
