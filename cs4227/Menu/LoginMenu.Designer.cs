namespace cs4227.Menu
{
    partial class LoginMenu
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
            this.WelcomeMessageLabel = new System.Windows.Forms.Label();
            this.LoginMessageLabel = new System.Windows.Forms.Label();
            this.DisplayDateLabel = new System.Windows.Forms.Label();
            this.DisplayTimeLabel = new System.Windows.Forms.Label();
            this.SysAdminLoginButton = new System.Windows.Forms.Button();
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.UserLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeMessageLabel
            // 
            this.WelcomeMessageLabel.AutoSize = true;
            this.WelcomeMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessageLabel.Location = new System.Drawing.Point(93, 89);
            this.WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            this.WelcomeMessageLabel.Size = new System.Drawing.Size(778, 73);
            this.WelcomeMessageLabel.TabIndex = 0;
            this.WelcomeMessageLabel.Text = "Welcome to Tap and Eat!";
            // 
            // LoginMessageLabel
            // 
            this.LoginMessageLabel.AutoSize = true;
            this.LoginMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMessageLabel.Location = new System.Drawing.Point(333, 175);
            this.LoginMessageLabel.Name = "LoginMessageLabel";
            this.LoginMessageLabel.Size = new System.Drawing.Size(288, 33);
            this.LoginMessageLabel.TabIndex = 1;
            this.LoginMessageLabel.Text = "Please Login Below";
            // 
            // DisplayDateLabel
            // 
            this.DisplayDateLabel.AutoSize = true;
            this.DisplayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayDateLabel.Location = new System.Drawing.Point(13, 13);
            this.DisplayDateLabel.Name = "DisplayDateLabel";
            this.DisplayDateLabel.Size = new System.Drawing.Size(68, 25);
            this.DisplayDateLabel.TabIndex = 2;
            this.DisplayDateLabel.Text = "Date:";
            // 
            // DisplayTimeLabel
            // 
            this.DisplayTimeLabel.AutoSize = true;
            this.DisplayTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTimeLabel.Location = new System.Drawing.Point(685, 13);
            this.DisplayTimeLabel.Name = "DisplayTimeLabel";
            this.DisplayTimeLabel.Size = new System.Drawing.Size(155, 25);
            this.DisplayTimeLabel.TabIndex = 3;
            this.DisplayTimeLabel.Text = "Current Time:";
            // 
            // SysAdminLoginButton
            // 
            this.SysAdminLoginButton.BackColor = System.Drawing.Color.Silver;
            this.SysAdminLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SysAdminLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysAdminLoginButton.Location = new System.Drawing.Point(13, 436);
            this.SysAdminLoginButton.Name = "SysAdminLoginButton";
            this.SysAdminLoginButton.Size = new System.Drawing.Size(302, 214);
            this.SysAdminLoginButton.TabIndex = 4;
            this.SysAdminLoginButton.Text = "SysAdmin Login";
            this.SysAdminLoginButton.UseVisualStyleBackColor = false;
            this.SysAdminLoginButton.Click += new System.EventHandler(this.SysAdminLoginButton_Click);
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.BackColor = System.Drawing.Color.Silver;
            this.AdminLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginButton.Location = new System.Drawing.Point(339, 436);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(302, 214);
            this.AdminLoginButton.TabIndex = 5;
            this.AdminLoginButton.Text = "Admin Login";
            this.AdminLoginButton.UseVisualStyleBackColor = false;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // UserLoginButton
            // 
            this.UserLoginButton.BackColor = System.Drawing.Color.Silver;
            this.UserLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginButton.Location = new System.Drawing.Point(670, 436);
            this.UserLoginButton.Name = "UserLoginButton";
            this.UserLoginButton.Size = new System.Drawing.Size(302, 214);
            this.UserLoginButton.TabIndex = 6;
            this.UserLoginButton.Text = "User Login";
            this.UserLoginButton.UseVisualStyleBackColor = false;
            this.UserLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.UserLoginButton);
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.SysAdminLoginButton);
            this.Controls.Add(this.DisplayTimeLabel);
            this.Controls.Add(this.DisplayDateLabel);
            this.Controls.Add(this.LoginMessageLabel);
            this.Controls.Add(this.WelcomeMessageLabel);
            this.Name = "LoginMenu";
            this.Text = "Tap And Eat: Login Menu";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessageLabel;
        private System.Windows.Forms.Label LoginMessageLabel;
        private System.Windows.Forms.Label DisplayDateLabel;
        private System.Windows.Forms.Label DisplayTimeLabel;
        private System.Windows.Forms.Button SysAdminLoginButton;
        private System.Windows.Forms.Button AdminLoginButton;
        private System.Windows.Forms.Button UserLoginButton;
    }
}