namespace POS_SYSTEM
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnManUsers = new System.Windows.Forms.Button();
            this.btnManProds = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOkinawa = new System.Windows.Forms.Button();
            this.btnWintermelon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbChange = new System.Windows.Forms.RichTextBox();
            this.rtbVATAmount = new System.Windows.Forms.RichTextBox();
            this.rtbVATable = new System.Windows.Forms.RichTextBox();
            this.rtbTotalAmtDue = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTransact = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCASH = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(13, 17);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "USER";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(13, 33);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(81, 17);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "POSITION";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Sienna;
            this.btnHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.BackgroundImage")));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(1238, 91);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(115, 98);
            this.btnHistory.TabIndex = 23;
            this.btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnManUsers
            // 
            this.btnManUsers.BackColor = System.Drawing.Color.Sienna;
            this.btnManUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManUsers.BackgroundImage")));
            this.btnManUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManUsers.ForeColor = System.Drawing.Color.Black;
            this.btnManUsers.Location = new System.Drawing.Point(1238, 195);
            this.btnManUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnManUsers.Name = "btnManUsers";
            this.btnManUsers.Size = new System.Drawing.Size(115, 98);
            this.btnManUsers.TabIndex = 22;
            this.btnManUsers.UseVisualStyleBackColor = false;
            this.btnManUsers.Click += new System.EventHandler(this.btnManUsers_Click);
            // 
            // btnManProds
            // 
            this.btnManProds.BackColor = System.Drawing.Color.Sienna;
            this.btnManProds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManProds.BackgroundImage")));
            this.btnManProds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManProds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManProds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManProds.ForeColor = System.Drawing.Color.Black;
            this.btnManProds.Location = new System.Drawing.Point(1239, 300);
            this.btnManProds.Margin = new System.Windows.Forms.Padding(4);
            this.btnManProds.Name = "btnManProds";
            this.btnManProds.Size = new System.Drawing.Size(115, 98);
            this.btnManProds.TabIndex = 21;
            this.btnManProds.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1233, 715);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 28);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.IndianRed;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(1233, 679);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(131, 28);
            this.btnChangePassword.TabIndex = 26;
            this.btnChangePassword.Text = "CHANGE PW";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 64);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 682);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.Tan;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.btnOkinawa);
            this.tabPage2.Controls.Add(this.btnWintermelon);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(845, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MILKTEA";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkKhaki;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(603, 135);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 98);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnOkinawa
            // 
            this.btnOkinawa.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnOkinawa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOkinawa.BackgroundImage")));
            this.btnOkinawa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOkinawa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkinawa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkinawa.ForeColor = System.Drawing.Color.Black;
            this.btnOkinawa.Location = new System.Drawing.Point(353, 135);
            this.btnOkinawa.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkinawa.Name = "btnOkinawa";
            this.btnOkinawa.Size = new System.Drawing.Size(115, 98);
            this.btnOkinawa.TabIndex = 27;
            this.btnOkinawa.UseVisualStyleBackColor = false;
            this.btnOkinawa.Click += new System.EventHandler(this.btnOkinawa_Click);
            // 
            // btnWintermelon
            // 
            this.btnWintermelon.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnWintermelon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWintermelon.BackgroundImage")));
            this.btnWintermelon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWintermelon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWintermelon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWintermelon.ForeColor = System.Drawing.Color.Black;
            this.btnWintermelon.Location = new System.Drawing.Point(100, 135);
            this.btnWintermelon.Margin = new System.Windows.Forms.Padding(4);
            this.btnWintermelon.Name = "btnWintermelon";
            this.btnWintermelon.Size = new System.Drawing.Size(115, 98);
            this.btnWintermelon.TabIndex = 26;
            this.btnWintermelon.UseVisualStyleBackColor = false;
            this.btnWintermelon.Click += new System.EventHandler(this.btnWintermelon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(275, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 91);
            this.label3.TabIndex = 23;
            this.label3.Text = "MILKTEA";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Tan;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(845, 651);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "MILKSHAKE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(240, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 91);
            this.label4.TabIndex = 24;
            this.label4.Text = "MILKSHAKE";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Tan;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(845, 651);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "FRAPPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(292, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 91);
            this.label5.TabIndex = 24;
            this.label5.Text = "FRAPPE";
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(985, 458);
            this.txtRemove.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(239, 22);
            this.txtRemove.TabIndex = 30;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(873, 456);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
            this.btnRemove.TabIndex = 29;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.rtbChange);
            this.panel1.Controls.Add(this.rtbVATAmount);
            this.panel1.Controls.Add(this.rtbVATable);
            this.panel1.Controls.Add(this.rtbTotalAmtDue);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnTransact);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbCASH);
            this.panel1.Location = new System.Drawing.Point(873, 489);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 257);
            this.panel1.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(173, 187);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 22);
            this.label16.TabIndex = 66;
            this.label16.Text = "₱";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(173, 75);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 22);
            this.label15.TabIndex = 65;
            this.label15.Text = "₱";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(173, 156);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 22);
            this.label17.TabIndex = 67;
            this.label17.Text = "₱";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(173, 43);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 22);
            this.label14.TabIndex = 64;
            this.label14.Text = "₱";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(173, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 22);
            this.label13.TabIndex = 63;
            this.label13.Text = "₱";
            // 
            // rtbChange
            // 
            this.rtbChange.BackColor = System.Drawing.Color.Cornsilk;
            this.rtbChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbChange.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbChange.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChange.Location = new System.Drawing.Point(200, 186);
            this.rtbChange.Margin = new System.Windows.Forms.Padding(4);
            this.rtbChange.Name = "rtbChange";
            this.rtbChange.ReadOnly = true;
            this.rtbChange.Size = new System.Drawing.Size(101, 24);
            this.rtbChange.TabIndex = 61;
            this.rtbChange.Text = "";
            // 
            // rtbVATAmount
            // 
            this.rtbVATAmount.BackColor = System.Drawing.Color.Cornsilk;
            this.rtbVATAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbVATAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbVATAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVATAmount.Location = new System.Drawing.Point(200, 74);
            this.rtbVATAmount.Margin = new System.Windows.Forms.Padding(4);
            this.rtbVATAmount.Name = "rtbVATAmount";
            this.rtbVATAmount.ReadOnly = true;
            this.rtbVATAmount.Size = new System.Drawing.Size(101, 24);
            this.rtbVATAmount.TabIndex = 60;
            this.rtbVATAmount.Text = "";
            // 
            // rtbVATable
            // 
            this.rtbVATable.BackColor = System.Drawing.Color.Cornsilk;
            this.rtbVATable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbVATable.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbVATable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVATable.Location = new System.Drawing.Point(200, 42);
            this.rtbVATable.Margin = new System.Windows.Forms.Padding(4);
            this.rtbVATable.Name = "rtbVATable";
            this.rtbVATable.ReadOnly = true;
            this.rtbVATable.Size = new System.Drawing.Size(101, 24);
            this.rtbVATable.TabIndex = 59;
            this.rtbVATable.Text = "";
            // 
            // rtbTotalAmtDue
            // 
            this.rtbTotalAmtDue.BackColor = System.Drawing.Color.Cornsilk;
            this.rtbTotalAmtDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTotalAmtDue.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbTotalAmtDue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTotalAmtDue.Location = new System.Drawing.Point(200, 13);
            this.rtbTotalAmtDue.Margin = new System.Windows.Forms.Padding(4);
            this.rtbTotalAmtDue.Name = "rtbTotalAmtDue";
            this.rtbTotalAmtDue.ReadOnly = true;
            this.rtbTotalAmtDue.Size = new System.Drawing.Size(101, 24);
            this.rtbTotalAmtDue.TabIndex = 58;
            this.rtbTotalAmtDue.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(77, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 57;
            this.label12.Text = "VAT Amount";
            // 
            // btnTransact
            // 
            this.btnTransact.BackColor = System.Drawing.Color.White;
            this.btnTransact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransact.Enabled = false;
            this.btnTransact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransact.Location = new System.Drawing.Point(200, 218);
            this.btnTransact.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(103, 33);
            this.btnTransact.TabIndex = 56;
            this.btnTransact.Text = "TRANSACT";
            this.btnTransact.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(103, 190);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 55;
            this.label11.Text = "Change";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(104, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "VATable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(36, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Total Amount Due";
            // 
            // tbCASH
            // 
            this.tbCASH.BackColor = System.Drawing.Color.Cornsilk;
            this.tbCASH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCASH.Location = new System.Drawing.Point(200, 155);
            this.tbCASH.Margin = new System.Windows.Forms.Padding(4);
            this.tbCASH.MaxLength = 9999999;
            this.tbCASH.Name = "tbCASH";
            this.tbCASH.Size = new System.Drawing.Size(101, 25);
            this.tbCASH.TabIndex = 51;
            this.tbCASH.Text = "0";
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.White;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(873, 91);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(351, 357);
            this.txtDisplay.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(122, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Cash";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnManUsers);
            this.Controls.Add(this.btnManProds);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_MouseUp);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnManUsers;
        private System.Windows.Forms.Button btnManProds;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOkinawa;
        private System.Windows.Forms.Button btnWintermelon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtbChange;
        private System.Windows.Forms.RichTextBox rtbVATAmount;
        private System.Windows.Forms.RichTextBox rtbVATable;
        private System.Windows.Forms.RichTextBox rtbTotalAmtDue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTransact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCASH;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label1;

    }
}