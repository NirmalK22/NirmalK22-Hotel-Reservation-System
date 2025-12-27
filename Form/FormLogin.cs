using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string username = gunaLineTextBox1.Text;
            string password = gunaLineTextBox2.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string sql = "SELECT user_Name, user_Password FROM User_Table WHERE user_Password = @Password AND user_Name = @Username";

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Username", username);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    MessageBox.Show("Login Success !..");
                                    this.Hide();
                                    FormDashboard d = new FormDashboard();
                                    d.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    gunaLineTextBox1.Clear();
                                    gunaLineTextBox2.Clear();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login2cs l = new Login2cs();
            l.Show();

        }
    }
}
