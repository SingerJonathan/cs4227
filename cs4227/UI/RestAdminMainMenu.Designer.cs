namespace cs4227.UI
{
    partial class RestAdminMainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RestaurantNameLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.EditAdminDetailsButton = new System.Windows.Forms.Button();
            this.AdminUsernameLabel = new System.Windows.Forms.Label();
            this.RestaurantAdminMenuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(382, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(382, 296);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "Change Restauraunt Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(382, 480);
            this.button4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "Manage Orders";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RestaurantNameLabel
            // 
            this.RestaurantNameLabel.AutoSize = true;
            this.RestaurantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantNameLabel.Location = new System.Drawing.Point(4, 92);
            this.RestaurantNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.RestaurantNameLabel.Name = "RestaurantNameLabel";
            this.RestaurantNameLabel.Size = new System.Drawing.Size(201, 25);
            this.RestaurantNameLabel.TabIndex = 4;
            this.RestaurantNameLabel.Text = "Restaurant Name:";
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Silver;
            this.LogOutButton.Location = new System.Drawing.Point(382, 569);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(300, 80);
            this.LogOutButton.TabIndex = 5;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // EditAdminDetailsButton
            // 
            this.EditAdminDetailsButton.BackColor = System.Drawing.Color.Silver;
            this.EditAdminDetailsButton.Location = new System.Drawing.Point(382, 207);
            this.EditAdminDetailsButton.Name = "EditAdminDetailsButton";
            this.EditAdminDetailsButton.Size = new System.Drawing.Size(300, 80);
            this.EditAdminDetailsButton.TabIndex = 1;
            this.EditAdminDetailsButton.Text = "Edit Admin Details";
            this.EditAdminDetailsButton.UseVisualStyleBackColor = false;
            this.EditAdminDetailsButton.Click += new System.EventHandler(this.EditAdminDetailsButton_Click);
            // 
            // AdminUsernameLabel
            // 
            this.AdminUsernameLabel.AutoSize = true;
            this.AdminUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUsernameLabel.Location = new System.Drawing.Point(4, 140);
            this.AdminUsernameLabel.Name = "AdminUsernameLabel";
            this.AdminUsernameLabel.Size = new System.Drawing.Size(197, 25);
            this.AdminUsernameLabel.TabIndex = 7;
            this.AdminUsernameLabel.Text = "Admin Username:";
            // 
            // RestaurantAdminMenuLabel
            // 
            this.RestaurantAdminMenuLabel.AutoSize = true;
            this.RestaurantAdminMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantAdminMenuLabel.Location = new System.Drawing.Point(151, 9);
            this.RestaurantAdminMenuLabel.Name = "RestaurantAdminMenuLabel";
            this.RestaurantAdminMenuLabel.Size = new System.Drawing.Size(745, 73);
            this.RestaurantAdminMenuLabel.TabIndex = 8;
            this.RestaurantAdminMenuLabel.Text = "Restaurant Admin Menu";
            // 
            // RestAdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.RestaurantAdminMenuLabel);
            this.Controls.Add(this.AdminUsernameLabel);
            this.Controls.Add(this.EditAdminDetailsButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.RestaurantNameLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RestAdminMainMenu";
            this.Text = "RestAdmin Menu: Main Menu";
            this.Load += new System.EventHandler(this.RestMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label RestaurantNameLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button EditAdminDetailsButton;
        private System.Windows.Forms.Label AdminUsernameLabel;
        private System.Windows.Forms.Label RestaurantAdminMenuLabel;
    }
}