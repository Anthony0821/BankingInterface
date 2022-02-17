
namespace BankingInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSatistics = new System.Windows.Forms.Button();
            this.BtnStatements = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnAccountBalance = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PNLNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BtnSatistics);
            this.panel1.Controls.Add(this.BtnStatements);
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnAccountBalance);
            this.panel1.Controls.Add(this.BtnProfile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 690);
            this.panel1.TabIndex = 0;
            // 
            // BtnSatistics
            // 
            this.BtnSatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnSatistics.Location = new System.Drawing.Point(0, 296);
            this.BtnSatistics.Name = "BtnSatistics";
            this.BtnSatistics.Size = new System.Drawing.Size(200, 48);
            this.BtnSatistics.TabIndex = 7;
            this.BtnSatistics.Text = "Statistics";
            this.BtnSatistics.UseVisualStyleBackColor = true;
            this.BtnSatistics.Click += new System.EventHandler(this.BtnSatistics_Click);
            this.BtnSatistics.Leave += new System.EventHandler(this.BtnSatistics_Leave);
            // 
            // BtnStatements
            // 
            this.BtnStatements.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStatements.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStatements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnStatements.Location = new System.Drawing.Point(0, 248);
            this.BtnStatements.Name = "BtnStatements";
            this.BtnStatements.Size = new System.Drawing.Size(200, 48);
            this.BtnStatements.TabIndex = 6;
            this.BtnStatements.Text = "Statements";
            this.BtnStatements.UseVisualStyleBackColor = true;
            this.BtnStatements.Click += new System.EventHandler(this.BtnStatements_Click);
            this.BtnStatements.Leave += new System.EventHandler(this.BtnStatements_Leave);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogout.Location = new System.Drawing.Point(0, 667);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(200, 23);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "Log out";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            this.BtnLogout.Leave += new System.EventHandler(this.BtnLogout_Leave);
            // 
            // BtnAccountBalance
            // 
            this.BtnAccountBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAccountBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAccountBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAccountBalance.Location = new System.Drawing.Point(0, 200);
            this.BtnAccountBalance.Name = "BtnAccountBalance";
            this.BtnAccountBalance.Size = new System.Drawing.Size(200, 48);
            this.BtnAccountBalance.TabIndex = 4;
            this.BtnAccountBalance.Text = "Account Balance";
            this.BtnAccountBalance.UseVisualStyleBackColor = true;
            this.BtnAccountBalance.Click += new System.EventHandler(this.BtnAccountBalance_Click);
            this.BtnAccountBalance.Leave += new System.EventHandler(this.BtnAccountBalance_Leave);
            // 
            // BtnProfile
            // 
            this.BtnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnProfile.Location = new System.Drawing.Point(0, 152);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(200, 48);
            this.BtnProfile.TabIndex = 3;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            this.BtnProfile.Leave += new System.EventHandler(this.BtnProfile_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PNLNav);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.User);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 152);
            this.panel2.TabIndex = 0;
            // 
            // PNLNav
            // 
            this.PNLNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PNLNav.Location = new System.Drawing.Point(0, 50);
            this.PNLNav.Name = "PNLNav";
            this.PNLNav.Size = new System.Drawing.Size(3, 100);
            this.PNLNav.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wednesday, February 16, 2022";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.User.Location = new System.Drawing.Point(73, 99);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(30, 15);
            this.User.TabIndex = 1;
            this.User.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankingInterface.Properties.Resources.default_profile_picture;
            this.pictureBox1.Location = new System.Drawing.Point(56, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(225, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Location = new System.Drawing.Point(1053, 30);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(299, 23);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.Text = "Can I help you find something?";
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(1365, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(225, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 204);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(225, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 239);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(547, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 475);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(932, 152);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 204);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(932, 388);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(420, 239);
            this.panel7.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1392, 690);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSatistics;
        private System.Windows.Forms.Button BtnStatements;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnAccountBalance;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PNLNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}

