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
        int loginid = frmLogin.loginid;
        MySqlDataReader reader;
        MySqlCommand command;


        string MilkTeaName;
        MilkTea mt = new MilkTea();
        int order;

        public frmMain()
        {
            InitializeComponent();

            lblUser.Text = user.ToUpper();
            lblPosition.Text = frmLogin.position;

            openDB();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            updateDisplay();
            if( position.ToLower() == "developer" || position.ToLower() == "admin")
            {
                btnManProds.Visible = true;
                btnManUsers.Visible = true;
            }
            else
            {
                btnManProds.Visible = false;
                btnManUsers.Visible = false;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.Show();
        }

        private void btnWintermelon_Click(object sender, EventArgs e)
        {
            MilkTeaName = "Wintermelon";
            frmMilkTea frmMilkTea = new frmMilkTea(MilkTeaName);
            frmMilkTea.ShowDialog();
            updateDisplay();
        }

        private void btnOkinawa_Click(object sender, EventArgs e)
        {
            MilkTeaName = "Okinawa";
            frmMilkTea frmMilkTea = new frmMilkTea(MilkTeaName);
            frmMilkTea.ShowDialog();
            updateDisplay();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                order = Convert.ToInt32(txtRemove.Text);
                TransactionHistory.History.RemoveAt(order);
                TransactionHistory.priceTotal.RemoveAt(order);
                Transact.Total = TransactionHistory.priceTotal.Sum();
                updateDisplay();
            }
            catch
            {
                MessageBox.Show("Please input an existing order");
                txtRemove.ResetText();
            }
        }

        private void btnManUsers_Click(object sender, EventArgs e)
        {
            frmUsersManager frmUsersManager = new frmUsersManager();
            frmUsersManager.ShowDialog();

        }


        private void openDB()
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.connectionString))
            {
                connection.Open();
                try
                {
                    string query = "SELECT password, MD5(tempopw) AS hashedTempo FROM " + DatabaseConnection.UsersTable + " WHERE loginid=@id;";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", loginid);
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

        private void updateDisplay()
        {
            txtDisplay.Clear();

            for (order = 0; order < TransactionHistory.History.Count(); order++)
            {
                txtDisplay.Text += "Order #: " + order + "\r\n\n" + TransactionHistory.History[order] + "\r\n\n";
            }

            //computeTransaction();


            rtbTotalAmtDue.Text = Transact.Total.ToString();
            rtbVATable.Text = Transact.VATable.ToString();
            rtbVATAmount.Text = Transact.VatAmt.ToString();
        }



        #region Miscellaneous Methods

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
                this.Opacity = 0.9;
                this.Update();
            }
        }
        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Opacity = 1;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            //formResize();
        }



        private void formResize()
        {
            //tabControl1.Size = new System.Drawing.Size(ClientSize.Width * 3 / 4, ClientSize.Height - 5);
            /*grpVendoUI.Size = new System.Drawing.Size(ClientSize.Width * 4 / 5, 850);
            grpVendoUI.Location = new System.Drawing.Point(ClientSize.Width / 2 - ((grpVendoUI.Size.Width) / 2), ClientSize.Height / 2 - ((grpVendoUI.Size.Height) / 2));
            txtName.Size = new System.Drawing.Size(grpVendoUI.Size.Width - 4, 45);
            txtCurrentCredit.Size = new System.Drawing.Size(grpVendoUI.Size.Width - lblCreditAmount.Size.Width, 45);
            txtCurrentCredit.Location = new System.Drawing.Point(lblCreditAmount.Size.Width + 2, txtName.Location.Y + txtName.Size.Height + 5);
            btnCash.Location = new System.Drawing.Point((grpVendoUI.Size.Width / 3) - (btnCash.Size.Width / 2) - (50), txtCurrentCredit.Location.Y + txtCurrentCredit.Size.Height + 15);
            btnCredit.Location = new System.Drawing.Point((grpVendoUI.Size.Width * 2 / 3) - (btnCredit.Size.Width / 2) + (50), btnCash.Location.Y);
            lblCoinsInserted.Location = new System.Drawing.Point((grpVendoUI.Size.Width / 2) - (lblCoinsInserted.Size.Width / 2), btnCredit.Location.Y + btnCredit.Size.Height + 15);
            btnCancel.Location = new System.Drawing.Point(grpVendoUI.Size.Width / 2 - ((btnCancel.Size.Width) / 2), lblProduct10.Location.Y + lblProduct10.Size.Height + 15);
            txtEmpID.Location = new System.Drawing.Point(ClientSize.Width / 2, ClientSize.Height / 2);
        
              */
        } 
        #endregion

    }
}
