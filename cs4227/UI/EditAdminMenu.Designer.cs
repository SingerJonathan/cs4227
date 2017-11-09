namespace cs4227.UI
{
    partial class EditAdminMenu
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
            this.AdminFirstNameLabel = new System.Windows.Forms.Label();
            this.AdminFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.AdminEmailLabel = new System.Windows.Forms.Label();
            this.AdminEmailTextbox = new System.Windows.Forms.TextBox();
            this.AdminUsernameLabel = new System.Windows.Forms.Label();
            this.AdminUsernameTextbox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AdminPasswordLabel = new System.Windows.Forms.Label();
            this.AdminPasswordTextbox = new System.Windows.Forms.TextBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.DeleteAdminButton = new System.Windows.Forms.Button();
            this.AdminLastNameLabel = new System.Windows.Forms.Label();
            this.AdminLastNameTextbox = new System.Windows.Forms.TextBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AdminFirstNameLabel
            // 
            this.AdminFirstNameLabel.AutoSize = true;
            this.AdminFirstNameLabel.Location = new System.Drawing.Point(324, 19);
            this.AdminFirstNameLabel.Name = "AdminFirstNameLabel";
            this.AdminFirstNameLabel.Size = new System.Drawing.Size(133, 25);
            this.AdminFirstNameLabel.TabIndex = 0;
            this.AdminFirstNameLabel.Text = "First Name:";
            // 
            // AdminFirstNameTextbox
            // 
            this.AdminFirstNameTextbox.Location = new System.Drawing.Point(329, 56);
            this.AdminFirstNameTextbox.Name = "AdminFirstNameTextbox";
            this.AdminFirstNameTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminFirstNameTextbox.TabIndex = 1;
            this.AdminFirstNameTextbox.TextChanged += new System.EventHandler(this.AdminFirstNameTextbox_TextChanged);
            // 
            // AdminEmailLabel
            // 
            this.AdminEmailLabel.AutoSize = true;
            this.AdminEmailLabel.Location = new System.Drawing.Point(324, 162);
            this.AdminEmailLabel.Name = "AdminEmailLabel";
            this.AdminEmailLabel.Size = new System.Drawing.Size(77, 25);
            this.AdminEmailLabel.TabIndex = 2;
            this.AdminEmailLabel.Text = "Email:";
            this.AdminEmailLabel.Click += new System.EventHandler(this.AdminEmailLabel_Click);
            // 
            // AdminEmailTextbox
            // 
            this.AdminEmailTextbox.Location = new System.Drawing.Point(329, 200);
            this.AdminEmailTextbox.Name = "AdminEmailTextbox";
            this.AdminEmailTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminEmailTextbox.TabIndex = 3;
            this.AdminEmailTextbox.TextChanged += new System.EventHandler(this.AdminEmailTextbox_TextChanged);
            // 
            // AdminUsernameLabel
            // 
            this.AdminUsernameLabel.AutoSize = true;
            this.AdminUsernameLabel.Location = new System.Drawing.Point(324, 249);
            this.AdminUsernameLabel.Name = "AdminUsernameLabel";
            this.AdminUsernameLabel.Size = new System.Drawing.Size(125, 25);
            this.AdminUsernameLabel.TabIndex = 4;
            this.AdminUsernameLabel.Text = "Username:";
            this.AdminUsernameLabel.Click += new System.EventHandler(this.AdminUsernameLabel_Click);
            // 
            // AdminUsernameTextbox
            // 
            this.AdminUsernameTextbox.Location = new System.Drawing.Point(329, 286);
            this.AdminUsernameTextbox.Name = "AdminUsernameTextbox";
            this.AdminUsernameTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminUsernameTextbox.TabIndex = 4;
            this.AdminUsernameTextbox.TextChanged += new System.EventHandler(this.AdminUsernameTextbox_TextChanged);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.Silver;
            this.SaveChangesButton.Location = new System.Drawing.Point(13, 465);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(300, 185);
            this.SaveChangesButton.TabIndex = 7;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Location = new System.Drawing.Point(672, 465);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(300, 185);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdminPasswordLabel
            // 
            this.AdminPasswordLabel.AutoSize = true;
            this.AdminPasswordLabel.Location = new System.Drawing.Point(324, 325);
            this.AdminPasswordLabel.Name = "AdminPasswordLabel";
            this.AdminPasswordLabel.Size = new System.Drawing.Size(121, 25);
            this.AdminPasswordLabel.TabIndex = 8;
            this.AdminPasswordLabel.Text = "Password:";
            this.AdminPasswordLabel.Click += new System.EventHandler(this.AdminPasswordLabel_Click);
            // 
            // AdminPasswordTextbox
            // 
            this.AdminPasswordTextbox.Location = new System.Drawing.Point(329, 374);
            this.AdminPasswordTextbox.Name = "AdminPasswordTextbox";
            this.AdminPasswordTextbox.PasswordChar = '*';
            this.AdminPasswordTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminPasswordTextbox.TabIndex = 5;
            this.AdminPasswordTextbox.TextChanged += new System.EventHandler(this.AdminPasswordTextbox_TextChanged);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(8, 420);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(173, 25);
            this.ErrorMessageLabel.TabIndex = 12;
            this.ErrorMessageLabel.Text = "Error Message:";
            this.ErrorMessageLabel.Visible = false;
            // 
            // DeleteAdminButton
            // 
            this.DeleteAdminButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteAdminButton.Location = new System.Drawing.Point(349, 465);
            this.DeleteAdminButton.Name = "DeleteAdminButton";
            this.DeleteAdminButton.Size = new System.Drawing.Size(300, 185);
            this.DeleteAdminButton.TabIndex = 8;
            this.DeleteAdminButton.Text = "Delete Admin";
            this.DeleteAdminButton.UseVisualStyleBackColor = false;
            this.DeleteAdminButton.Click += new System.EventHandler(this.DeleteAdminButton_Click);
            // 
            // AdminLastNameLabel
            // 
            this.AdminLastNameLabel.AutoSize = true;
            this.AdminLastNameLabel.Location = new System.Drawing.Point(324, 90);
            this.AdminLastNameLabel.Name = "AdminLastNameLabel";
            this.AdminLastNameLabel.Size = new System.Drawing.Size(131, 25);
            this.AdminLastNameLabel.TabIndex = 14;
            this.AdminLastNameLabel.Text = "Last Name:";
            // 
            // AdminLastNameTextbox
            // 
            this.AdminLastNameTextbox.Location = new System.Drawing.Point(329, 128);
            this.AdminLastNameTextbox.Name = "AdminLastNameTextbox";
            this.AdminLastNameTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminLastNameTextbox.TabIndex = 2;
            this.AdminLastNameTextbox.TextChanged += new System.EventHandler(this.AdminLastNameTextbox_TextChanged);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(635, 363);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(197, 29);
            this.ShowPasswordCheckBox.TabIndex = 6;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // EditAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.AdminLastNameTextbox);
            this.Controls.Add(this.AdminLastNameLabel);
            this.Controls.Add(this.DeleteAdminButton);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.AdminPasswordTextbox);
            this.Controls.Add(this.AdminPasswordLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.AdminUsernameTextbox);
            this.Controls.Add(this.AdminUsernameLabel);
            this.Controls.Add(this.AdminEmailTextbox);
            this.Controls.Add(this.AdminEmailLabel);
            this.Controls.Add(this.AdminFirstNameTextbox);
            this.Controls.Add(this.AdminFirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "EditAdminMenu";
            this.Text = "EditAdminMenu";
            this.Load += new System.EventHandler(this.EditAdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminFirstNameLabel;
        private System.Windows.Forms.TextBox AdminFirstNameTextbox;
        private System.Windows.Forms.Label AdminEmailLabel;
        private System.Windows.Forms.TextBox AdminEmailTextbox;
        private System.Windows.Forms.Label AdminUsernameLabel;
        private System.Windows.Forms.TextBox AdminUsernameTextbox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label AdminPasswordLabel;
        private System.Windows.Forms.TextBox AdminPasswordTextbox;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Button DeleteAdminButton;
        private System.Windows.Forms.Label AdminLastNameLabel;
        private System.Windows.Forms.TextBox AdminLastNameTextbox;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
    }
}