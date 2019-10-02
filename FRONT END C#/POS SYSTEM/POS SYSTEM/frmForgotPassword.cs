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
    public partial class frmForgotPassword : Form
    {
        MySqlDataReader reader;
        MySqlCommand command;
        string connectionString;
        string password ="";
        string uname = "";
        private bool mouseDown;
        private Point lastLocation;



        public frmForgotPassword()
        {
            InitializeComponent();
            this.txtUsername.Text = frmLogin.unamez;
        }

        private void openForm()
        {
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.Show();
        }


        private void openDB()
        {
            connectionString = @"server=localhost;database=logindb;uid=root;pwd=root";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE tbllogin SET tempopw=(SELECT substring(MD5(RAND()), -8)) WHERE UserName=@Uname;"+
                        "UPDATE tbllogin SET password=MD5(tempopw), isEnabled = 1, log_attempts = 0 WHERE UserName=@Uname;"+
                        "SELECT tempopw, PassWord, UserName FROM tblLogin WHERE UserName = @Uname AND answer1 = @Answer1 OR answer2 = @Answer2; ";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Uname", txtUsername.Text);
                    command.Parameters.AddWithValue("@Answer1", txtAnswer1.Text);
                    command.Parameters.AddWithValue("@Answer2", txtAnswer2.Text);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        password = reader["tempopw"].ToString();
                        uname = reader["UserName"].ToString();
                    }
                    reader.Close();
                    command.Dispose();



                    if (uname != "")
                    {
                        MessageBox.Show("Your temporary password is : " + password, "Reset password successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.ResetText();
                        txtAnswer1.ResetText();
                        txtAnswer2.ResetText();
                        uname = "";
                        openForm();
                    }
                    else
                    {
                        MessageBox.Show("Answers did not match username!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            openDB();
            frmLogin.unamez = this.txtUsername.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            openForm();
            frmLogin.unamez = this.txtUsername.Text;
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                openDB();
            }
        }




        // ----------------- Form Move Implementation  (Drag Form Body) ------------------
        public void form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        public void form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Opacity = 0.8;
                this.Update();
            }
        }
        public void form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Opacity = 1;
        }

        public void txtBoxes_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        public void txtBoxes_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "")
            {
                btnSubmit.Enabled = true;
            }
        }

    }
}
