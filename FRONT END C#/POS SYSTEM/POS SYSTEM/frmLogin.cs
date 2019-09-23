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
        public static string user = "";
        public static string position = "";
        string connectionString;
        private bool mouseDown;
        private Point lastLocation;


        public frmLogin()
        {
            InitializeComponent();
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

        private void logIn()
        {
            connectionString = @"server=localhost;database=logindb;uid=root;pwd=root";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "SELECT CONCAT(FirstName,' ',LastName) AS FullName, Position FROM tblLogin WHERE UserName = @Username AND PassWord = @Password";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        user = reader["FullName"].ToString();
                        position = reader["Position"].ToString();
                    }
                    reader.Close();
                    command.Dispose();
                    if (user == "")
                    {
                        MessageBox.Show("Invalid login details", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Text = "";
                        txtPassword.Text = "";
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

        // ----------------- Form Move Implementation  (Drag Form Body) ------------------
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
    }
}
