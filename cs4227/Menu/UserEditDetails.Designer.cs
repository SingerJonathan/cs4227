﻿namespace cs4227.Menu
{
    partial class UserManageAccount
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.UserEmailTextbox = new System.Windows.Forms.TextBox();
            this.UserEmailLabel = new System.Windows.Forms.Label();
            this.UserPasswordTextbox = new System.Windows.Forms.TextBox();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.UserUsernameTextbox = new System.Windows.Forms.TextBox();
            this.UserUsernameLabel = new System.Windows.Forms.Label();
            this.UserNameTextbox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Location = new System.Drawing.Point(672, 569);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(300, 80);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.Silver;
            this.SaveChangesButton.Location = new System.Drawing.Point(12, 569);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(300, 80);
            this.SaveChangesButton.TabIndex = 1;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteAccountButton.Location = new System.Drawing.Point(340, 569);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(300, 80);
            this.DeleteAccountButton.TabIndex = 2;
            this.DeleteAccountButton.Text = "Delete Account";
            this.DeleteAccountButton.UseVisualStyleBackColor = false;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // UserEmailTextbox
            // 
            this.UserEmailTextbox.Location = new System.Drawing.Point(340, 372);
            this.UserEmailTextbox.Name = "UserEmailTextbox";
            this.UserEmailTextbox.Size = new System.Drawing.Size(300, 31);
            this.UserEmailTextbox.TabIndex = 3;
            this.UserEmailTextbox.TextChanged += new System.EventHandler(this.UserEmailTextbox_TextChanged);
            // 
            // UserEmailLabel
            // 
            this.UserEmailLabel.AutoSize = true;
            this.UserEmailLabel.Location = new System.Drawing.Point(335, 335);
            this.UserEmailLabel.Name = "UserEmailLabel";
            this.UserEmailLabel.Size = new System.Drawing.Size(77, 25);
            this.UserEmailLabel.TabIndex = 4;
            this.UserEmailLabel.Text = "Email:";
            // 
            // UserPasswordTextbox
            // 
            this.UserPasswordTextbox.Location = new System.Drawing.Point(340, 301);
            this.UserPasswordTextbox.Name = "UserPasswordTextbox";
            this.UserPasswordTextbox.Size = new System.Drawing.Size(300, 31);
            this.UserPasswordTextbox.TabIndex = 5;
            this.UserPasswordTextbox.TextChanged += new System.EventHandler(this.UserPasswordTextbox_TextChanged);
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(335, 263);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(121, 25);
            this.UserPasswordLabel.TabIndex = 6;
            this.UserPasswordLabel.Text = "Password:";
            // 
            // UserUsernameTextbox
            // 
            this.UserUsernameTextbox.Location = new System.Drawing.Point(340, 229);
            this.UserUsernameTextbox.Name = "UserUsernameTextbox";
            this.UserUsernameTextbox.Size = new System.Drawing.Size(300, 31);
            this.UserUsernameTextbox.TabIndex = 7;
            this.UserUsernameTextbox.TextChanged += new System.EventHandler(this.UserUsernameTextbox_TextChanged);
            // 
            // UserUsernameLabel
            // 
            this.UserUsernameLabel.AutoSize = true;
            this.UserUsernameLabel.Location = new System.Drawing.Point(335, 191);
            this.UserUsernameLabel.Name = "UserUsernameLabel";
            this.UserUsernameLabel.Size = new System.Drawing.Size(125, 25);
            this.UserUsernameLabel.TabIndex = 8;
            this.UserUsernameLabel.Text = "Username:";
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Location = new System.Drawing.Point(340, 157);
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.Size = new System.Drawing.Size(300, 31);
            this.UserNameTextbox.TabIndex = 9;
            this.UserNameTextbox.TextChanged += new System.EventHandler(this.UserNameTextbox_TextChanged);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(335, 119);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(79, 25);
            this.UserNameLabel.TabIndex = 10;
            this.UserNameLabel.Text = "Name:";
            // 
            // UserManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.UserUsernameLabel);
            this.Controls.Add(this.UserUsernameTextbox);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UserPasswordTextbox);
            this.Controls.Add(this.UserEmailLabel);
            this.Controls.Add(this.UserEmailTextbox);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "UserManageAccount";
            this.Text = "User Menu: Edit User Details";
            this.Load += new System.EventHandler(this.UserManageAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.TextBox UserEmailTextbox;
        private System.Windows.Forms.Label UserEmailLabel;
        private System.Windows.Forms.TextBox UserPasswordTextbox;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.TextBox UserUsernameTextbox;
        private System.Windows.Forms.Label UserUsernameLabel;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.Label UserNameLabel;
    }
}