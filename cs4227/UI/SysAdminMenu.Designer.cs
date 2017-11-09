namespace cs4227.UI
{
    partial class SysAdminMenu
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
            this.RestaurantsButton = new System.Windows.Forms.Button();
            this.AdminsButton = new System.Windows.Forms.Button();
            this.DisplayDateLabel = new System.Windows.Forms.Label();
            this.DisplayTimeLabel = new System.Windows.Forms.Label();
            this.SystemAdminMenuLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RestaurantsButton
            // 
            this.RestaurantsButton.BackColor = System.Drawing.Color.Silver;
            this.RestaurantsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestaurantsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantsButton.Location = new System.Drawing.Point(250, 350);
            this.RestaurantsButton.Name = "RestaurantsButton";
            this.RestaurantsButton.Size = new System.Drawing.Size(500, 80);
            this.RestaurantsButton.TabIndex = 1;
            this.RestaurantsButton.Text = "Restaurants";
            this.RestaurantsButton.UseVisualStyleBackColor = false;
            this.RestaurantsButton.Click += new System.EventHandler(this.RestaurantsButton_Click);
            // 
            // AdminsButton
            // 
            this.AdminsButton.BackColor = System.Drawing.Color.Silver;
            this.AdminsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminsButton.Location = new System.Drawing.Point(250, 436);
            this.AdminsButton.Name = "AdminsButton";
            this.AdminsButton.Size = new System.Drawing.Size(500, 80);
            this.AdminsButton.TabIndex = 2;
            this.AdminsButton.Text = "Admins";
            this.AdminsButton.UseVisualStyleBackColor = false;
            this.AdminsButton.Click += new System.EventHandler(this.AdminsButton_Click);
            // 
            // DisplayDateLabel
            // 
            this.DisplayDateLabel.AutoSize = true;
            this.DisplayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayDateLabel.Location = new System.Drawing.Point(12, 9);
            this.DisplayDateLabel.Name = "DisplayDateLabel";
            this.DisplayDateLabel.Size = new System.Drawing.Size(68, 25);
            this.DisplayDateLabel.TabIndex = 5;
            this.DisplayDateLabel.Text = "Date:";
            // 
            // DisplayTimeLabel
            // 
            this.DisplayTimeLabel.AutoSize = true;
            this.DisplayTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTimeLabel.Location = new System.Drawing.Point(697, 9);
            this.DisplayTimeLabel.Name = "DisplayTimeLabel";
            this.DisplayTimeLabel.Size = new System.Drawing.Size(155, 25);
            this.DisplayTimeLabel.TabIndex = 6;
            this.DisplayTimeLabel.Text = "Current Time:";
            // 
            // SystemAdminMenuLabel
            // 
            this.SystemAdminMenuLabel.AutoSize = true;
            this.SystemAdminMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemAdminMenuLabel.Location = new System.Drawing.Point(83, 181);
            this.SystemAdminMenuLabel.Name = "SystemAdminMenuLabel";
            this.SystemAdminMenuLabel.Size = new System.Drawing.Size(844, 73);
            this.SystemAdminMenuLabel.TabIndex = 7;
            this.SystemAdminMenuLabel.Text = "System Administrator Menu";
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Silver;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(250, 523);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(500, 80);
            this.LogOutButton.TabIndex = 8;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SysAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.SystemAdminMenuLabel);
            this.Controls.Add(this.DisplayTimeLabel);
            this.Controls.Add(this.DisplayDateLabel);
            this.Controls.Add(this.AdminsButton);
            this.Controls.Add(this.RestaurantsButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SysAdminMenu";
            this.Text = "SysAdmin Menu";
            this.Load += new System.EventHandler(this.SysAdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestaurantsButton;
        private System.Windows.Forms.Button AdminsButton;
        private System.Windows.Forms.Label DisplayDateLabel;
        private System.Windows.Forms.Label DisplayTimeLabel;
        private System.Windows.Forms.Label SystemAdminMenuLabel;
        private System.Windows.Forms.Button LogOutButton;
    }
}