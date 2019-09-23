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
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "USER";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(12, 22);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(66, 13);
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
            this.btnHistory.Location = new System.Drawing.Point(846, 242);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(86, 80);
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
            this.btnManUsers.Location = new System.Drawing.Point(846, 157);
            this.btnManUsers.Name = "btnManUsers";
            this.btnManUsers.Size = new System.Drawing.Size(85, 80);
            this.btnManUsers.TabIndex = 22;
            this.btnManUsers.UseVisualStyleBackColor = false;
            // 
            // btnManProds
            // 
            this.btnManProds.BackColor = System.Drawing.Color.Sienna;
            this.btnManProds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManProds.BackgroundImage")));
            this.btnManProds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManProds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManProds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManProds.ForeColor = System.Drawing.Color.Black;
            this.btnManProds.Location = new System.Drawing.Point(846, 72);
            this.btnManProds.Name = "btnManProds";
            this.btnManProds.Size = new System.Drawing.Size(86, 80);
            this.btnManProds.TabIndex = 21;
            this.btnManProds.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(834, 462);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(98, 23);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(943, 491);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnManUsers);
            this.Controls.Add(this.btnManProds);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
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

    }
}