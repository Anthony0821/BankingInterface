
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EarningLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Statistics = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.Statistics.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(200, 763);
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
            this.BtnLogout.Location = new System.Drawing.Point(0, 740);
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
            this.User.Click += new System.EventHandler(this.User_Click);
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
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DarkRed;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitBtn.Location = new System.Drawing.Point(1365, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.ProfileLabel);
            this.panel3.Location = new System.Drawing.Point(225, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 204);
            this.panel3.TabIndex = 4;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProfileLabel.Location = new System.Drawing.Point(0, 0);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(100, 23);
            this.ProfileLabel.TabIndex = 0;
            this.ProfileLabel.Text = "Profile";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.EarningLabel);
            this.panel4.Location = new System.Drawing.Point(225, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 239);
            this.panel4.TabIndex = 5;
            // 
            // EarningLabel
            // 
            this.EarningLabel.AutoSize = true;
            this.EarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EarningLabel.Location = new System.Drawing.Point(0, 0);
            this.EarningLabel.Name = "EarningLabel";
            this.EarningLabel.Size = new System.Drawing.Size(93, 24);
            this.EarningLabel.TabIndex = 0;
            this.EarningLabel.Text = "Earnings";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(547, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 475);
            this.panel5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(111, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Accounts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(932, 152);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 204);
            this.panel6.TabIndex = 7;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stocks";
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Statistics.Controls.Add(this.label3);
            this.Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Statistics.Location = new System.Drawing.Point(932, 388);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(420, 239);
            this.Statistics.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Balance History";
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(225, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 39);
            this.panel8.TabIndex = 9;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1388, 763);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.exitBtn);
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
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.Statistics.ResumeLayout(false);
            this.Statistics.PerformLayout();
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
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel Statistics;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EarningLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

