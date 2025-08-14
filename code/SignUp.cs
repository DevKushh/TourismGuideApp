using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;

namespace TourismApp
{
    public partial class SignUp : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader dr;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=LAPTOP-N05B4HU6\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Thankyou for Registering....!");
            }
            catch (Exception e1)
            {
                MessageBox.Show("error" + e1);
            }
            //Validation Section
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    cmd = new SqlCommand("select * from Login where Email ='"+ textBox1.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Login values(@Email, @Password)", conn);
                        cmd.Parameters.AddWithValue("Email", textBox1.Text);
                        cmd.Parameters.AddWithValue("Password", textBox2.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both Passwords same ", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all fields...!", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginPage loginpage = new LoginPage();
            loginpage.ShowDialog();
        }
    }
}
