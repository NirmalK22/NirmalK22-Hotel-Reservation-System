using Guna.UI.WinForms;
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

namespace Hotel.CustomerControler
{
    public partial class CustomerConrolerset : Form
    {
        public CustomerConrolerset()
        {
            InitializeComponent();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard d= new FormDashboard();
            d.Show();
        }

        //Add User Deatils
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string username = gunaTextBox1.Text;
            string password = gunaTextBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) )
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO User_Table (user_Password, user_Name) VALUES (@Password, @Username)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details added successfully!");
                            gunaTextBox1.Clear();
                            gunaTextBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //View Details
        private void gunaButton5_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT user_ID AS 'ID',user_Name AS 'Username',user_Password AS 'Password' from User_Table";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }`
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Search Details
        private void gunaButton6_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string username = gunaTextBox4.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT user_ID AS 'ID',user_Name AS 'Username',user_Password AS 'Password' from User_Table WHERE user_Name=@username";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                        gunaTextBox4.Clear();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Upadte User vDetails
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string username = gunaTextBox5.Text;
            string password = gunaTextBox3.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "Update User_Table set user_Password=@password where user_Name=@username";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details are successfully Updated!");                           
                            gunaTextBox1.Clear();
                            gunaTextBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update user details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Delete Details
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string username = gunaTextBox1.Text;
            string password = gunaTextBox2.Text;
            int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();



                    string sql = "delete from User_Table where user_ID=@ID";
                              
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@ID", ID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details successfully Deleted!");
                            gunaTextBox1.Clear();
                            gunaTextBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete user details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
