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
    public partial class UserCustomer : Form
    {
        public UserCustomer()
        {
            InitializeComponent();
        }

        //Back to Dashboard
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard d=new FormDashboard();    
            d.Show();   
        }

        
        //Add Deatils in Customer
        private void AddUser_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string FirstName = gunaTextBox1.Text;
            string LastName = gunaTextBox2.Text;
            string PhoneNO = gunaTextBox3.Text;
            string Address = gunaTextBox4.Text;

            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(PhoneNO) || string.IsNullOrWhiteSpace(Address))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Customer_Table (Customer_First_Name, Customer_Last_Name,Customer_Phone_No,Customer_Address) VALUES (@FirstName, @LastName,@PhoneNO,@Address)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@PhoneNO", PhoneNO);
                        command.Parameters.AddWithValue("@Address", Address);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details added successfully!");
                            gunaTextBox1.Clear();
                            gunaTextBox2.Clear();
                            gunaTextBox3.Clear();
                            gunaTextBox4.Clear();
;                        }
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
        private void BTNview_Click(object sender, EventArgs e)
        {
          

                string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
                
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string sql = "SELECT Customer_ID AS 'ID',Customer_First_Name AS 'First Name',Customer_Last_Name AS 'Last Name',Customer_Phone_No AS 'PhoneNo',Customer_Address AS 'Address'   from Customer_Table";

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

        //Search Details
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string PhoneNo = txtphone.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT Customer_ID AS 'ID',Customer_First_Name AS 'First Name',Customer_Last_Name AS 'Last Name',Customer_Phone_No AS 'PhoneNo',Customer_Address AS 'Address'   from Customer_Table WHERE Customer_Phone_No=@PhoneNo";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PhoneNo", PhoneNo);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                        txtphone.Clear();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        //Delete the details
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string PhoneNo = txtphone.Text;            
            int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();



                    string sql = "delete from Customer_Table where Customer_ID=@ID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                       
                        command.Parameters.AddWithValue("@ID", ID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer details are successfully Deleted!");
                            txtphone.Clear();

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
        //Update the details
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-N9FPSDOT;Initial Catalog=Hotel_Manage_System;Integrated Security=true";
            string FirstName = gunaTextBox6.Text;
            string LastName = gunaTextBox5.Text;
            string PhoneNo = gunaTextBox7.Text;
            string Address = gunaTextBox9.Text;


            //Data Validation
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(PhoneNo) || string.IsNullOrWhiteSpace(Address))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "Update Customer_Table set Customer_First_Name=@FirstName,Customer_Last_Name=@LastName,Customer_Address=@Address where Customer_Phone_No=@PhoneNo";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@PhoneNo", PhoneNo);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer details are successfully Updated!");
                            gunaTextBox6.Clear();
                            gunaTextBox5.Clear();
                            gunaTextBox7.Clear();
                            gunaTextBox9.Clear();

                        }
                        else
                        {
                            MessageBox.Show("No user found with the provided phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
