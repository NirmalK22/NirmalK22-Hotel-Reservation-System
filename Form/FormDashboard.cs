using Hotel.CustomerControler;
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

namespace Hotel
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin l = new FormLogin();
                l.Show();
            }
            else
            { }
        }


        ////Dashboard to Customer
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserCustomer u = new UserCustomer();
            u.Show();
        }

        ////Dashboard to Room
        private void btnRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRooms r = new UserRooms();
            r.Show();
        }

        //Dashboard to Resrvation
        private void btnReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserReservation r = new UserReservation();
            r.Show();
        }


        //Dashboard to Usersetting 
        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login2cs l = new Login2cs();
            l.Show();
        }
    }
}
