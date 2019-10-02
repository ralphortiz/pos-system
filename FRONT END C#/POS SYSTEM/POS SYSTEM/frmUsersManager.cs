using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public partial class frmUsersManager : Form
    {
        MySqlDataReader reader;
        MySqlCommand command;
        string connectionString;
        private bool mouseDown;
        private Point lastLocation;

        public static int LoginID = 0;


        public frmUsersManager()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void txtBoxes_TextChanged(object sender, EventArgs e)
        {
            if ( txtFirstname.Text != "" && txtLastname.Text != "" && txtPosition.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }


    }
}
