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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using System.Xml.Linq;
using System.Configuration;

namespace TourismApp
{
    public partial class BookingDetails : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader dr;
        public BookingDetails()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=LAPTOP-N05B4HU6\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            conn = new SqlConnection(connString);
          //  string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

            // Get the values from the form controls
            string name = textBox1.Text;
            string email = textBox2.Text;
            string phone = textBox3.Text;
            string departure = comboBox1.SelectedItem.ToString();
            string destination = comboBox2.SelectedItem.ToString();
            DateTime travelDate = dateTimePicker1.Value;
            int passengerCount = Convert.ToInt32(textBox4.Text);

            // Create the SQL query to insert the data into the database
            string query = "INSERT INTO Booking (Name, Email, Phone, Departure, Destination, TravelDate, Passengers) " +
                           "VALUES (@Name, @Email, @Phone, @Departure, @Destination, @TravelDate, @Passengers)";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter values to the command
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Departure", departure);
                    command.Parameters.AddWithValue("@Destination", destination);
                    command.Parameters.AddWithValue("@TravelDate", travelDate);
                    command.Parameters.AddWithValue("@Passengers", passengerCount);

                    // Open the database connection
                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();

                    // Close the connection
                    connection.Close();
                }
            }

            // Optionally, display a success message or perform other actions
            MessageBox.Show("ThankYou For Booking...!"+"\nPlease Check Email For Booked Tickets... ");
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox4.Text = " ";
        }
    }
}

