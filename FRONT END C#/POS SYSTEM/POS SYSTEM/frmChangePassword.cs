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
    public partial class frmChangePassword : Form
    {

        MySqlDataReader reader;
        MySqlCommand command;
        string connectionString;
        private bool mouseDown;
        private Point lastLocation;

        public static int LoginID = 0;


        public frmChangePassword()
        {
            InitializeComponent();
            txtUsername.Text = frmLogin.unamez;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submitPassword();
        }

        private void submitPassword()
        {
            if(txtNewPassword.Text == txtConfirmPassword.Text && txtNewPassword.TextLength >= 8)
            {
                openDB();
            }
            else
            {
                MessageBox.Show("New password and confirm password be identical. \n Password must be more than 8 characters.", "Invalid New Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.ResetText();
                txtConfirmPassword.ResetText();
                txtNewPassword.Focus();
            }
        }

        private void openDB()
        {
            connectionString = @"server=localhost;database=logindb;uid=root;pwd=root";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "SELECT CONCAT(FirstName,' ',LastName) AS FullName, Position, LoginID FROM tblLogin WHERE UserName = @Username AND PassWord = MD5(@Password)";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtOldPassword.Text);
                    reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        LoginID = Convert.ToInt32(reader["LoginID"]);
                    }
                    reader.Close();
                    command.Dispose();

                    if (LoginID == 0)
                    {
                        MessageBox.Show("Old password is incorrect!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtOldPassword.ResetText();
                        txtOldPassword.Focus();
                    }
                    else
                    {
                        string query2 = "UPDATE tbllogin SET password=MD5(@NewPW), isEnabled = 1, log_attempts = 0 WHERE username=@Username;";
                        command = new MySqlCommand(query2, connection);
                        command.Parameters.AddWithValue("@Username", txtUsername.Text);
                        command.Parameters.AddWithValue("@Password", txtOldPassword.Text);
                        command.Parameters.AddWithValue("@NewPW", txtNewPassword.Text);
                        reader = command.ExecuteReader();
                        reader.Close();
                        command.Dispose();

                        MessageBox.Show("Change Password Successful!", "Hoorei!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void txtBoxes_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        public void txtBoxes_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPassword.Text != "" &&  txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                btnSubmit.Enabled = true;
            }
        }

        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
            txtConfirmPassword.PasswordChar = '\0';
        }

        private void showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPassword.PasswordChar = '●';
            txtConfirmPassword.PasswordChar = '●';
        }

    }
}
