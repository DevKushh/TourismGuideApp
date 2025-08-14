using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TourismApp
{
    public partial class LoginPage : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader dr;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string a = textBox1.Text;
                string b = textBox2.Text;
                string sql = "select * from Login where Email='" + a + "' and Password = '" + b + "'";
                string connString = "Data Source=LAPTOP-N05B4HU6\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                       // MessageBox.Show(" You are authenticated");
                        BookingDetails bookingdetails = new BookingDetails();
                        bookingdetails.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentals");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Error: " + e1);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
