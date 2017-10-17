﻿namespace cs4227.source.Menus
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
            this.AdminNameLabel = new System.Windows.Forms.Label();
            this.AdminNameTextbox = new System.Windows.Forms.TextBox();
            this.AdminEmailLabel = new System.Windows.Forms.Label();
            this.AdminEmailTextbox = new System.Windows.Forms.TextBox();
            this.AdminUsernameLabel = new System.Windows.Forms.Label();
            this.AdminUsernameTextbox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AdminPasswordLabel = new System.Windows.Forms.Label();
            this.AdminPasswordTextbox = new System.Windows.Forms.TextBox();
            this.AdminRestaurantLabel = new System.Windows.Forms.Label();
            this.AdminRestaurantTextbox = new System.Windows.Forms.TextBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminNameLabel
            // 
            this.AdminNameLabel.AutoSize = true;
            this.AdminNameLabel.Location = new System.Drawing.Point(344, 9);
            this.AdminNameLabel.Name = "AdminNameLabel";
            this.AdminNameLabel.Size = new System.Drawing.Size(79, 25);
            this.AdminNameLabel.TabIndex = 0;
            this.AdminNameLabel.Text = "Name:";
            // 
            // AdminNameTextbox
            // 
            this.AdminNameTextbox.Location = new System.Drawing.Point(349, 47);
            this.AdminNameTextbox.Name = "AdminNameTextbox";
            this.AdminNameTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminNameTextbox.TabIndex = 1;
            this.AdminNameTextbox.TextChanged += new System.EventHandler(this.AdminNameTextbox_TextChanged);
            // 
            // AdminEmailLabel
            // 
            this.AdminEmailLabel.AutoSize = true;
            this.AdminEmailLabel.Location = new System.Drawing.Point(344, 81);
            this.AdminEmailLabel.Name = "AdminEmailLabel";
            this.AdminEmailLabel.Size = new System.Drawing.Size(77, 25);
            this.AdminEmailLabel.TabIndex = 2;
            this.AdminEmailLabel.Text = "Email:";
            // 
            // AdminEmailTextbox
            // 
            this.AdminEmailTextbox.Location = new System.Drawing.Point(349, 119);
            this.AdminEmailTextbox.Name = "AdminEmailTextbox";
            this.AdminEmailTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminEmailTextbox.TabIndex = 3;
            this.AdminEmailTextbox.TextChanged += new System.EventHandler(this.AdminEmailTextbox_TextChanged);
            // 
            // AdminUsernameLabel
            // 
            this.AdminUsernameLabel.AutoSize = true;
            this.AdminUsernameLabel.Location = new System.Drawing.Point(344, 153);
            this.AdminUsernameLabel.Name = "AdminUsernameLabel";
            this.AdminUsernameLabel.Size = new System.Drawing.Size(125, 25);
            this.AdminUsernameLabel.TabIndex = 4;
            this.AdminUsernameLabel.Text = "Username:";
            // 
            // AdminUsernameTextbox
            // 
            this.AdminUsernameTextbox.Location = new System.Drawing.Point(349, 190);
            this.AdminUsernameTextbox.Name = "AdminUsernameTextbox";
            this.AdminUsernameTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminUsernameTextbox.TabIndex = 5;
            this.AdminUsernameTextbox.TextChanged += new System.EventHandler(this.AdminUsernameTextbox_TextChanged);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.Silver;
            this.SaveChangesButton.Location = new System.Drawing.Point(13, 465);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(300, 185);
            this.SaveChangesButton.TabIndex = 6;
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
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdminPasswordLabel
            // 
            this.AdminPasswordLabel.AutoSize = true;
            this.AdminPasswordLabel.Location = new System.Drawing.Point(344, 224);
            this.AdminPasswordLabel.Name = "AdminPasswordLabel";
            this.AdminPasswordLabel.Size = new System.Drawing.Size(121, 25);
            this.AdminPasswordLabel.TabIndex = 8;
            this.AdminPasswordLabel.Text = "Password:";
            // 
            // AdminPasswordTextbox
            // 
            this.AdminPasswordTextbox.Location = new System.Drawing.Point(349, 262);
            this.AdminPasswordTextbox.Name = "AdminPasswordTextbox";
            this.AdminPasswordTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminPasswordTextbox.TabIndex = 9;
            this.AdminPasswordTextbox.TextChanged += new System.EventHandler(this.AdminPasswordTextbox_TextChanged);
            // 
            // AdminRestaurantLabel
            // 
            this.AdminRestaurantLabel.AutoSize = true;
            this.AdminRestaurantLabel.Location = new System.Drawing.Point(344, 296);
            this.AdminRestaurantLabel.Name = "AdminRestaurantLabel";
            this.AdminRestaurantLabel.Size = new System.Drawing.Size(134, 25);
            this.AdminRestaurantLabel.TabIndex = 10;
            this.AdminRestaurantLabel.Text = "Restaurant:";
            // 
            // AdminRestaurantTextbox
            // 
            this.AdminRestaurantTextbox.Location = new System.Drawing.Point(349, 333);
            this.AdminRestaurantTextbox.Name = "AdminRestaurantTextbox";
            this.AdminRestaurantTextbox.Size = new System.Drawing.Size(300, 31);
            this.AdminRestaurantTextbox.TabIndex = 11;
            this.AdminRestaurantTextbox.TextChanged += new System.EventHandler(this.AdminRestaurantTextbox_TextChanged);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(8, 405);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(173, 25);
            this.ErrorMessageLabel.TabIndex = 12;
            this.ErrorMessageLabel.Text = "Error Message:";
            this.ErrorMessageLabel.Visible = false;
            // 
            // EditAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.AdminRestaurantTextbox);
            this.Controls.Add(this.AdminRestaurantLabel);
            this.Controls.Add(this.AdminPasswordTextbox);
            this.Controls.Add(this.AdminPasswordLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.AdminUsernameTextbox);
            this.Controls.Add(this.AdminUsernameLabel);
            this.Controls.Add(this.AdminEmailTextbox);
            this.Controls.Add(this.AdminEmailLabel);
            this.Controls.Add(this.AdminNameTextbox);
            this.Controls.Add(this.AdminNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "EditAdminMenu";
            this.Text = "EditAdminMenu";
            this.Load += new System.EventHandler(this.EditAdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminNameLabel;
        private System.Windows.Forms.TextBox AdminNameTextbox;
        private System.Windows.Forms.Label AdminEmailLabel;
        private System.Windows.Forms.TextBox AdminEmailTextbox;
        private System.Windows.Forms.Label AdminUsernameLabel;
        private System.Windows.Forms.TextBox AdminUsernameTextbox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label AdminPasswordLabel;
        private System.Windows.Forms.TextBox AdminPasswordTextbox;
        private System.Windows.Forms.Label AdminRestaurantLabel;
        private System.Windows.Forms.TextBox AdminRestaurantTextbox;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}