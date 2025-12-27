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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel.CustomerControler
{
    public partial class UserReservation : Form
    {
        public UserReservation()
        {
            InitializeComponent();
        }

        //Back to the Dashboard
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard d = new FormDashboard();
            d.Show();
        }


        //Add Reservations
        private void btnADD_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string RoomType = comboBox1.Text;
            string CustomerID = gunaTextBox2.Text;
            string RoomNo = gunaTextBox1.Text;          
            string IN = dateTimePicker1.Text;          
            string OUT =dateTimePicker2.Text ;

            RoomType.ToLower();
            
            //Data Validation
            if (string.IsNullOrWhiteSpace(RoomType) || string.IsNullOrWhiteSpace(CustomerID)|| string.IsNullOrWhiteSpace(RoomNo))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Reservation_Table (Reservation_Room_Type, Reservation_Room_Number,Reservation_Customer_ID,Reservation_In,Reservation_Out) VALUES (@RoomType, @RoomNo,@CustomerID,@IN,@OUT)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@RoomType", RoomType);
                        command.Parameters.AddWithValue("@RoomNo", RoomNo);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@IN", IN);
                        command.Parameters.AddWithValue("@OUT", OUT);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details added successfully!");
                            comboBox1.Text = "";
                            gunaTextBox1.Clear();
                            gunaTextBox2.Clear();
                            dateTimePicker1.Value = dateTimePicker1.MinDate;
                            dateTimePicker2.Value = dateTimePicker2.MinDate;

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

        //view Reservation

        private void btnView_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT Reservation_Room_Type AS Room_Type,Reservation_Room_Number AS Room_Number,Reservation_Customer_ID AS Customer_ID, Reservation_In AS Reservation_IN,Reservation_Out AS Reservation_Out FROM Reservation_Table";

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


        //Search Reservation
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";

            string Cus_ID = gunaLineTextBox1.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT Reservation_Room_Type AS Room_Type,Reservation_Room_Number AS Room_Number,Reservation_Customer_ID AS Customer_ID, Reservation_In AS Reservation_IN,Reservation_Out AS Reservation_Out FROM Reservation_Table WHERE Reservation_Customer_ID=@CusId ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        command.Parameters.AddWithValue("@CusId", Cus_ID);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        gunaLineTextBox1.Clear();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Delete Deatails in DataGride View
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
           
            int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Customer_ID"].Value);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();



                    string sql = "delete from Reservation_Table where Reservation_Customer_ID=@ID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                      
                        command.Parameters.AddWithValue("@ID",ID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation details successfully Deleted!");
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


        //Update the Deatils
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
          
            string RoomType = comboBox2.Text;
            string CustomerID = gunaTextBox4.Text;
            string RoomNo = gunaTextBox3.Text;          
            string IN = dateTimePicker3.Text;           
            string OUT = dateTimePicker4.Text;

            //Data Validation
            if (string.IsNullOrWhiteSpace(RoomType) || string.IsNullOrWhiteSpace(CustomerID) || string.IsNullOrWhiteSpace(RoomNo))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "Update Reservation_Table set Reservation_Room_Type=@RoomType, Reservation_Room_Number=@RoomNo ,Reservation_In=@IN ,Reservation_Out=@OUT where Reservation_Customer_ID=@CustomerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@RoomType", RoomType);
                        command.Parameters.AddWithValue("@RoomNo", RoomNo);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@IN", IN);
                        command.Parameters.AddWithValue("@OUT", OUT);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details are successfully Updated!");
                            comboBox2.Text = "";
                            gunaTextBox4.Clear();
                            gunaTextBox3.Clear();
                            dateTimePicker3.Value = dateTimePicker3.MinDate;
                            dateTimePicker4.Value = dateTimePicker4.MinDate;
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
    }


}
