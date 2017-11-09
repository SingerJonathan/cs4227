namespace cs4227.UI
{
    partial class SysAdminAdminsMenu
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
            this.AdminsList = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RestaurantAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddAdminButton = new System.Windows.Forms.Button();
            this.AdminUsernameTextbox = new System.Windows.Forms.TextBox();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.AdminUsernameLabel = new System.Windows.Forms.Label();
            this.SelectAdminMessageLabel = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminsList
            // 
            this.AdminsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.RestaurantAdmin});
            this.AdminsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminsList.FullRowSelect = true;
            this.AdminsList.Location = new System.Drawing.Point(13, 54);
            this.AdminsList.MultiSelect = false;
            this.AdminsList.Name = "AdminsList";
            this.AdminsList.Size = new System.Drawing.Size(551, 596);
            this.AdminsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AdminsList.TabIndex = 1;
            this.AdminsList.UseCompatibleStateImageBehavior = false;
            this.AdminsList.View = System.Windows.Forms.View.Details;
            this.AdminsList.SelectedIndexChanged += new System.EventHandler(this.AdminsList_SelectedIndexChanged);
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 300;
            // 
            // RestaurantAdmin
            // 
            this.RestaurantAdmin.Text = "Restaurant";
            this.RestaurantAdmin.Width = 250;
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.BackColor = System.Drawing.Color.Silver;
            this.AddAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminButton.Location = new System.Drawing.Point(570, 427);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(350, 80);
            this.AddAdminButton.TabIndex = 3;
            this.AddAdminButton.Text = "Add Admin";
            this.AddAdminButton.UseVisualStyleBackColor = false;
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // AdminUsernameTextbox
            // 
            this.AdminUsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUsernameTextbox.Location = new System.Drawing.Point(570, 390);
            this.AdminUsernameTextbox.Name = "AdminUsernameTextbox";
            this.AdminUsernameTextbox.Size = new System.Drawing.Size(350, 31);
            this.AdminUsernameTextbox.TabIndex = 2;
            this.AdminUsernameTextbox.TextChanged += new System.EventHandler(this.AdminUsernameTextbox_TextChanged);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.BackColor = System.Drawing.Color.Silver;
            this.BackToMainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenuButton.Location = new System.Drawing.Point(570, 513);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(350, 80);
            this.BackToMainMenuButton.TabIndex = 4;
            this.BackToMainMenuButton.Text = "Back";
            this.BackToMainMenuButton.UseVisualStyleBackColor = false;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // AdminUsernameLabel
            // 
            this.AdminUsernameLabel.AutoSize = true;
            this.AdminUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUsernameLabel.Location = new System.Drawing.Point(565, 352);
            this.AdminUsernameLabel.Name = "AdminUsernameLabel";
            this.AdminUsernameLabel.Size = new System.Drawing.Size(188, 25);
            this.AdminUsernameLabel.TabIndex = 14;
            this.AdminUsernameLabel.Text = "Enter Username:";
            // 
            // SelectAdminMessageLabel
            // 
            this.SelectAdminMessageLabel.AutoSize = true;
            this.SelectAdminMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAdminMessageLabel.Location = new System.Drawing.Point(12, 9);
            this.SelectAdminMessageLabel.Name = "SelectAdminMessageLabel";
            this.SelectAdminMessageLabel.Size = new System.Drawing.Size(271, 25);
            this.SelectAdminMessageLabel.TabIndex = 16;
            this.SelectAdminMessageLabel.Text = "Select an Admin to view:";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.Location = new System.Drawing.Point(565, 214);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(166, 25);
            this.ErrorMessageLabel.TabIndex = 17;
            this.ErrorMessageLabel.Text = "Error Message";
            this.ErrorMessageLabel.Visible = false;
            // 
            // SysAdminAdminsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.SelectAdminMessageLabel);
            this.Controls.Add(this.AdminUsernameLabel);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.AdminUsernameTextbox);
            this.Controls.Add(this.AddAdminButton);
            this.Controls.Add(this.AdminsList);
            this.Name = "SysAdminAdminsMenu";
            this.Text = "SysAdmin Menu: Admins";
            this.Load += new System.EventHandler(this.SysAdminAdminsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AdminsList;
        private System.Windows.Forms.Button AddAdminButton;
        private System.Windows.Forms.TextBox AdminUsernameTextbox;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.Label AdminUsernameLabel;
        private System.Windows.Forms.Label SelectAdminMessageLabel;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader RestaurantAdmin;
    }
}