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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel.CustomerControler
{
    public partial class UserRooms : Form
    {
        public UserRooms()
        {
            InitializeComponent();


        }

        //Back to Dashboard.....///
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard d = new FormDashboard();
            d.Show();
        }

        //Add the Rooms
        private void btnADD_Click(object sender, EventArgs e)
        {
            string RoomType = comboBox1.Text;
            string PhoneNo = gunaTextBox1.Text;
            string available = comboBox3.Text;

            // Validate input data
            if (string.IsNullOrWhiteSpace(RoomType) || string.IsNullOrWhiteSpace(PhoneNo) || string.IsNullOrWhiteSpace(available))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionS = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
                SqlConnection con = new SqlConnection(connectionS);
                con.Open();

                string sql = @"insert into Room_Table(Room_Type,Room_Phone,Room_Free) values(@RoomType, @PhoneNo, @available)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@RoomType", RoomType);
                cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                cmd.Parameters.AddWithValue("@available", available);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room Details added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //View Details
        private void btnView_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            //  string username = gunaTextBox1.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT Room_Number AS 'Number',Room_Type AS 'RoomType',Room_Phone AS 'RoomPhone',Room_Free AS 'RoomFree' from Room_Table";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Delete the Details in datagride view
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";

            int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Number"].Value);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();



                    string sql = "delete from Room_Table where Room_Number=@ID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@ID", ID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room Details Are successfully Deleted!");
                            gunaTextBox1.Clear();
                            //gunaTextBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Room details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Upadte the Room details
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string Roomtype = comboBox2.Text;
            string RoomFree = comboBox4.Text;
            string PhoneNo = gunaLineTextBox1.Text;

            //Data Validation
            if (string.IsNullOrWhiteSpace(PhoneNo))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "Update Room_Table set Room_Type=@RoomType,Room_Free=@RoomFree where Room_Phone=@PhoneNo";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Roomtype", Roomtype);
                        command.Parameters.AddWithValue("@RoomFree", RoomFree);
                        command.Parameters.AddWithValue("@PhoneNo", PhoneNo);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room details are successfully Updated!");
                            comboBox2.Text = "";
                            comboBox4.Text = "";
                            gunaLineTextBox1.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Room details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Search details 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";

            string RoomType = lblroomsearch.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT Room_Type AS RoomType,Room_Phone AS RoomPhone,Room_Free AS RoomFree  FROM Room_Table WHERE Room_Type=@RoomType ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        command.Parameters.AddWithValue("@Room_Type", RoomType);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                        lblroomsearch.Clear();




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
