using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public partial class frmLogin : Form
    {
        MySqlDataReader reader;
        MySqlCommand command;
        MySqlCommand cmd = new MySqlCommand();
        public static string user = "";
        public static string position = "";
        public static int LoginID;
        public static string unamez = "";
        public static string connectionString;


        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Text = frmLogin.unamez;
            txtUsername.SelectAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logIn();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logIn();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        // ----------------------------------- Methods -----------------------------------




        private void logIn()
        {
            unamez = txtUsername.Text;
            connectionString = @"server=localhost;database=logindb;uid=root;pwd=root";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //cmd.Connection = connection;
                //cmd.CommandText = "DROP PROCEDURE IF EXISTS invalidLogin";
                //cmd.ExecuteNonQuery();
                //cmd.CommandText ="CREATE PROCEDURE invalidLogin(IN uname varchar(20), OUT logAttempt INT(3), OUT userIsEnabled TINYINT) BEGIN UPDATE tbllogin SET log_attempts = log_attempts + 1 WHERE tbllogin.username = uname;  IF (SELECT log_attempts FROM tbllogin WHERE tbllogin.username = uname) > 2 THEN UPDATE tbllogin SET isEnabled = 0 WHERE tbllogin.username = uname; SET userIsEnabled = 0; ELSE SET userIsEnabled = 1; END IF; SET logAttempt = (select log_attempts from tbllogin WHERE tbllogin.username = uname); END";
                //cmd.ExecuteNonQuery();
                try
                {
                    string query = "SELECT CONCAT(FirstName,' ',LastName) AS FullName, Position, LoginID FROM tblLogin WHERE UserName = @Username AND PassWord = MD5(@Password)";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        user = reader["FullName"].ToString();
                        position = reader["Position"].ToString().ToUpper();
                        LoginID = Convert.ToInt32(reader["LoginID"]);
                    }
                    reader.Close();
                    command.Dispose();



                    if (user == "")
                    {
                        MessageBox.Show("Invalid login details", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtUsername.Focus();
                    }
                    else
                    {
                        //lblDisplay.Text = result;
                        //MessageBox.Show(user + " " + position);
                        //lblUser.Text = user.ToUpper();
                        //lblPosition.Text = position;
                        frmMain frmMain = new frmMain();
                        this.Hide();
                        frmMain.Show();
                    }
                    user = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            unamez = this.txtUsername.Text;
            frmForgotPassword frmForgotPassword = new frmForgotPassword();
            this.Hide();
            frmForgotPassword.Show();
        }


        // ----------------- Form Move Implementation  (Drag Form Body) ------------------

        private bool mouseDown;
        private Point lastLocation;
        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Opacity = 0.8;
                this.Update();
            }
        }
        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Opacity = 1;
        }

        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}