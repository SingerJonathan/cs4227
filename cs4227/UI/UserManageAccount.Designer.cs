namespace cs4227.UI
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
            this.UserFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.UserFirstNameLabel = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.UserLastNameLabel = new System.Windows.Forms.Label();
            this.UserLastNameTextbox = new System.Windows.Forms.TextBox();
            this.MembershipComboBox = new System.Windows.Forms.ComboBox();
            this.MembershipLabel = new System.Windows.Forms.Label();
            this.PasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Location = new System.Drawing.Point(672, 569);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(300, 80);
            this.BackButton.TabIndex = 10;
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
            this.SaveChangesButton.TabIndex = 8;
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
            this.DeleteAccountButton.TabIndex = 9;
            this.DeleteAccountButton.Text = "Delete Account";
            this.DeleteAccountButton.UseVisualStyleBackColor = false;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // UserEmailTextbox
            // 
            this.UserEmailTextbox.Location = new System.Drawing.Point(498, 230);
            this.UserEmailTextbox.Name = "UserEmailTextbox";
            this.UserEmailTextbox.Size = new System.Drawing.Size(300, 31);
            this.UserEmailTextbox.TabIndex = 5;
            this.UserEmailTextbox.TextChanged += new System.EventHandler(this.UserEmailTextbox_TextChanged);
            // 
            // UserEmailLabel
            // 
            this.UserEmailLabel.AutoSize = true;
            this.UserEmailLabel.Location = new System.Drawing.Point(493, 193);
            this.UserEmailLabel.Name = "UserEmailLabel";
            this.UserEmailLabel.Size = new System.Drawing.Size(77, 25);
            this.UserEmailLabel.TabIndex = 4;
            this.UserEmailLabel.Text = "Email:";
            // 
            // UserPasswordTextbox
            // 
            this.UserPasswordTextbox.Location = new System.Drawing.Point(498, 159);
            this.UserPasswordTextbox.Name = "UserPasswordTextbox";
            this.UserPasswordTextbox.PasswordChar = '*';
            this.UserPasswordTextbox.Size = new System.Drawing.Size(300, 31);
            this.UserPasswordTextbox.TabIndex = 2;
            this.UserPasswordTextbox.TextChanged += new System.EventHandler(this.UserPasswordTextbox_TextChanged);
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(493, 120);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(121, 25);
            this.UserPasswordLabel.TabIndex = 6;
            this.UserPasswordLabel.Text = "Password:";
            // 
            // UserUsernameTextbox
            // 
            this.UserUsernameTextbox.Location = new System.Drawing.Point(157, 301);
            this.UserUsernameTextbox.Name = "UserUsernameTextbox";
            this.UserUsernameTextbox.Size = new System.Drawing.Size(300, 31);
            this.UserUsernameTextbox.TabIndex = 6;
            this.UserUsernameTextbox.TextChanged += new System.EventHandler(this.UserUsernameTextbox_TextChanged);
            // 
            // UserUsernameLabel
            // 
            this.UserUsernameLabel.AutoSize = true;
            this.UserUsernameLabel.Location = new System.Drawing.Point(152, 264);
            this.UserUsernameLabel.Name = "UserUsernameLabel";
            this.UserUsernameLabel.Size = new System.Drawing.Size(125, 25);
            this.UserUsernameLabel.TabIndex = 8;
            this.UserUsernameLabel.Text = "Username:";
            // 
            // UserFirstNameTextbox
            // 
            this.UserFirstNameTextbox.Location = new System.Drawing.Point(157, 159);
            this.UserFirstNameTextbox.Name = "UserFirstNameTextbox";
            this.UserFirstNameTextbox.Size = new System.Drawing.Size(300, 31);
            this.UserFirstNameTextbox.TabIndex = 1;
            this.UserFirstNameTextbox.TextChanged += new System.EventHandler(this.UserFirstNameTextbox_TextChanged);
            // 
            // UserFirstNameLabel
            // 
            this.UserFirstNameLabel.AutoSize = true;
            this.UserFirstNameLabel.Location = new System.Drawing.Point(152, 120);
            this.UserFirstNameLabel.Name = "UserFirstNameLabel";
            this.UserFirstNameLabel.Size = new System.Drawing.Size(133, 25);
            this.UserFirstNameLabel.TabIndex = 10;
            this.UserFirstNameLabel.Text = "First Name:";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(12, 471);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(173, 25);
            this.ErrorMessageLabel.TabIndex = 11;
            this.ErrorMessageLabel.Text = "Error Message:";
            // 
            // UserLastNameLabel
            // 
            this.UserLastNameLabel.AutoSize = true;
            this.UserLastNameLabel.Location = new System.Drawing.Point(152, 193);
            this.UserLastNameLabel.Name = "UserLastNameLabel";
            this.UserLastNameLabel.Size = new System.Drawing.Size(131, 25);
            this.UserLastNameLabel.TabIndex = 13;
            this.UserLastNameLabel.Text = "Last Name:";
            // 
            // UserLastNameTextbox
            // 
            this.UserLastNameTextbox.Location = new System.Drawing.Point(157, 230);
            this.UserLastNameTextbox.Name = "UserLastNameTextbox";
            this.UserLastNameTextbox.Size = new System.Drawing.Size(300, 31);
            this.UserLastNameTextbox.TabIndex = 4;
            this.UserLastNameTextbox.TextChanged += new System.EventHandler(this.UserLastNameTextbox_TextChanged);
            // 
            // MembershipComboBox
            // 
            this.MembershipComboBox.FormattingEnabled = true;
            this.MembershipComboBox.Items.AddRange(new object[] {
            "Basic (Free)",
            "Bronze (5.00/month)",
            "Silver (8.00/month)",
            "Gold (12.00/month)"});
            this.MembershipComboBox.Location = new System.Drawing.Point(498, 302);
            this.MembershipComboBox.Name = "MembershipComboBox";
            this.MembershipComboBox.Size = new System.Drawing.Size(300, 33);
            this.MembershipComboBox.TabIndex = 7;
            this.MembershipComboBox.SelectedIndexChanged += new System.EventHandler(this.MembershipComboBox_SelectedIndexChanged);
            // 
            // MembershipLabel
            // 
            this.MembershipLabel.AutoSize = true;
            this.MembershipLabel.Location = new System.Drawing.Point(493, 264);
            this.MembershipLabel.Name = "MembershipLabel";
            this.MembershipLabel.Size = new System.Drawing.Size(147, 25);
            this.MembershipLabel.TabIndex = 15;
            this.MembershipLabel.Text = "Membership:";
            // 
            // PasswordCheckbox
            // 
            this.PasswordCheckbox.AutoSize = true;
            this.PasswordCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordCheckbox.Location = new System.Drawing.Point(804, 161);
            this.PasswordCheckbox.Name = "PasswordCheckbox";
            this.PasswordCheckbox.Size = new System.Drawing.Size(177, 28);
            this.PasswordCheckbox.TabIndex = 3;
            this.PasswordCheckbox.Text = "Show Password";
            this.PasswordCheckbox.UseVisualStyleBackColor = true;
            this.PasswordCheckbox.CheckedChanged += new System.EventHandler(this.PasswordCheckbox_CheckedChanged);
            // 
            // UserManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.PasswordCheckbox);
            this.Controls.Add(this.MembershipLabel);
            this.Controls.Add(this.MembershipComboBox);
            this.Controls.Add(this.UserLastNameLabel);
            this.Controls.Add(this.UserLastNameTextbox);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.UserFirstNameLabel);
            this.Controls.Add(this.UserFirstNameTextbox);
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
        private System.Windows.Forms.TextBox UserFirstNameTextbox;
        private System.Windows.Forms.Label UserFirstNameLabel;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Label UserLastNameLabel;
        private System.Windows.Forms.TextBox UserLastNameTextbox;
        private System.Windows.Forms.ComboBox MembershipComboBox;
        private System.Windows.Forms.Label MembershipLabel;
        private System.Windows.Forms.CheckBox PasswordCheckbox;
    }
}