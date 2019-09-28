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
    public partial class frmMain : Form 
    {
        string password = "x", hashedTempo = "z";
        string user = frmLogin.user.ToUpper();
        string position = frmLogin.position.ToUpperInvariant();
        int LoginID = frmLogin.LoginID;
        MySqlDataReader reader;
        MySqlCommand command;
        string connectionString;
        private bool mouseDown;
        private Point lastLocation;

        public frmMain()
        {
            InitializeComponent();

            lblUser.Text = user.ToUpper();
            lblPosition.Text = frmLogin.position;

            openDB();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void openDB()
        {
            connectionString = @"server=localhost;database=logindb;uid=root;pwd=root";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "SELECT password, MD5(tempopw) AS hashedTempo FROM tbllogin WHERE LoginID=@id;";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", LoginID);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        password = reader["password"].ToString();
                        hashedTempo = reader["hashedTempo"].ToString();
                    }

                    reader.Close();
                    command.Dispose();

                    if (password == hashedTempo)
                    {
                        MessageBox.Show("It seems you haven't changed your password yet. Please change your password first.", "Temporary Password Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        frmChangePassword frmChangePassword = new frmChangePassword();
                        frmChangePassword.ShowDialog();

                    }
                    else
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
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
                this.Opacity = 0.9;
                this.Update();
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            }
        }
        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Opacity = 1;
            this.FormBorderStyle = FormBorderStyle.None;
        }

    }
}
