using Hotel.CustomerControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel
{
    public partial class Login2cs : Form
    {
        public Login2cs()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {


            string username, password;

            username = gunaLineTextBox1.Text;
            password = gunaLineTextBox2.Text;


            if (username.ToLower() == "admin" && password == "1234")
            {

                this.Hide();
                CustomerConrolerset cs = new CustomerConrolerset();
                cs.Show();
            }
            else
            {
                MessageBox.Show("Username or Password invalid  ");
            }
            
            
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard d=new FormDashboard();
            d.Show();
        }
    }
}
