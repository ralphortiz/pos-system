using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_SYSTEM
{
    public partial class frmLogin : Form
    {
        SqlDataReader reader;
        SqlCommand command;
        public static string user = "";
        public static string position = "";
        string connectionString;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connectionString = @"Server=RALPH\SQLEXPRESS; Database=loginDB; User ID=sa; Password=vickyjaneralph14";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "SELECT CONCAT(FirstName,' ',LastName) AS FullName, TypeOfUser FROM tblLogin WHERE UserName = @Username AND PassWord = @Password";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        user = reader["FullName"].ToString();
                        position = reader["TypeOfUser"].ToString();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
