namespace cs4227.Menu
{
    partial class RestMenu
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RestaurantAdminMessageLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(382, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Menu Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(382, 183);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 104);
            this.button2.TabIndex = 1;
            this.button2.Text = "Change Restauraunt Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(382, 299);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 104);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add User to Ignore List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(382, 415);
            this.button4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 104);
            this.button4.TabIndex = 3;
            this.button4.Text = "Manage Order";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RestaurantAdminMessageLabel
            // 
            this.RestaurantAdminMessageLabel.AutoSize = true;
            this.RestaurantAdminMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantAdminMessageLabel.Location = new System.Drawing.Point(16, 9);
            this.RestaurantAdminMessageLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.RestaurantAdminMessageLabel.Name = "RestaurantAdminMessageLabel";
            this.RestaurantAdminMessageLabel.Size = new System.Drawing.Size(315, 39);
            this.RestaurantAdminMessageLabel.TabIndex = 4;
            this.RestaurantAdminMessageLabel.Text = "Restaurant Name:";
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Silver;
            this.LogOutButton.Location = new System.Drawing.Point(382, 528);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(280, 104);
            this.LogOutButton.TabIndex = 5;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // RestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.RestaurantAdminMessageLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RestMenu";
            this.Text = "Restaurant Admin: Restaurant Menu";
            this.Load += new System.EventHandler(this.RestMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label RestaurantAdminMessageLabel;
        private System.Windows.Forms.Button LogOutButton;
    }
}