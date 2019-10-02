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
    public partial class frmMilkTea : Form
    {
        MilkTea Milktea = new MilkTea();
        Transact Transact = new Transact();
        CheckBox chk;
        RadioButton rb;
        double sinkers;
        double quantity = 0;
        public static string hist;

        MySqlDataReader reader;
        MySqlCommand command;


        public frmMilkTea(string MilkTeaName)
        {
            InitializeComponent();
            Milktea.MilkteaName = MilkTeaName;
            lblMilkTeaName.Text = Milktea.MilkteaName;
            numQuantity.Text = quantity.ToString();
            rbtn100P.Checked = true;
        }

        private void getSizePrice(object sender, EventArgs e)
        {
            rb = sender as RadioButton;
            if (rb.Text == "Regular")
            {
                Milktea.SizePrice = 69;

            }
            else if (rb.Text == "Large")
            {
                Milktea.SizePrice = 79;

            }
            Milktea.Size = rb.Text;
        }
        private void getSugarLevel(object sender, EventArgs e)
        {
            rb = sender as RadioButton;
            Milktea.SugarLevel = rb.Text;
        }

        private double getSinkersPrice(object sender)
        {
            chk = sender as CheckBox;
            if (chk.Text == "Pearl")
            {
                sinkers = 10;
            }
            else if (chk.Text == "Coffee Jelly")
            {
                sinkers = 10;
            }
            else if (chk.Text == "Coconut Jelly")
            {
                sinkers = 15;
            }
            else if (chk.Text == "Pudding")
            {
                sinkers = 20;
            }
            else if (chk.Text == "Aloe")
            {
                sinkers = 15;
            }
            else if (chk.Text == "Red Bean")
            {
                sinkers = 20;
            }
            return sinkers;
        }
        private void getSinkers(object sender, EventArgs e)
        {
            chk = sender as CheckBox;
            if (chk.Checked == true)
            {
                Milktea.Sinkers += chk.Text + " ";
                Milktea.SinkerPrice += getSinkersPrice(sender);
                sinkers = 0;
            }
            else if (chk.Checked == false)
            {
                Milktea.Sinkers = Milktea.Sinkers.Replace(chk.Text, "");
                Milktea.SinkerPrice -= getSinkersPrice(sender);
                sinkers = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Milktea.Quantity = Convert.ToDouble(numQuantity.Value);
            Milktea.ComputePrice();
            TransactionHistory.priceTotal.Add(Milktea.MilkteaPrice);
            Transact.Total = TransactionHistory.priceTotal.Sum();
            hist = "Milktea: " + Milktea.MilkteaName + "\r\n" + "Size: " + Milktea.Size + "\r\n" + "Sugar Level: " + Milktea.SugarLevel + "\r\n" + "Add-ons: " + Milktea.Sinkers + "\r\n" + "Price: " + Milktea.MilkteaPrice.ToString() + "\r\n";
            TransactionHistory.History.Add(hist);
            this.Close();
        }


        /*
        private void openDB()
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.connectionString))
            {
                connection.Open();
                try
                {
                    //string query = "SELECT name, size, price, isMilkTea, isMilkShake, isFrappe FROM " + DatabaseConnection.ProductsTable + " WHERE isAvailable = 1";
                    //command = new MySqlCommand(query, connection);
                    //reader = command.ExecuteReader();

                    //while (reader.Read())
                    //{
                    //    password = reader["password"].ToString();
                    //    hashedTempo = reader["hashedTempo"].ToString();
                    //}

                    //reader.Close();
                    //command.Dispose();

                    //if (password == hashedTempo)
                    //{
                    //    MessageBox.Show("It seems you haven't changed your password yet. Please change your password first.", "Temporary Password Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    frmChangePassword frmChangePassword = new frmChangePassword();
                    //    frmChangePassword.ShowDialog();

                    //}
                    //else
                    //{
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }*/



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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
