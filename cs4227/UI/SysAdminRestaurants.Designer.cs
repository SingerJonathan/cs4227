namespace cs4227.UI
{
    partial class SysAdminRestaurantsMenu
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
            this.ListOfRestaurants = new System.Windows.Forms.ListView();
            this.ListOfRestaurantsNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddRestaurantButton = new System.Windows.Forms.Button();
            this.RestaurantNameTextbox = new System.Windows.Forms.TextBox();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.SelectRestaurantMessageLabel = new System.Windows.Forms.Label();
            this.RestaurantNameLabel = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfRestaurants
            // 
            this.ListOfRestaurants.BackColor = System.Drawing.SystemColors.Window;
            this.ListOfRestaurants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListOfRestaurantsNames});
            this.ListOfRestaurants.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfRestaurants.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ListOfRestaurants.Location = new System.Drawing.Point(31, 48);
            this.ListOfRestaurants.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ListOfRestaurants.MultiSelect = false;
            this.ListOfRestaurants.Name = "ListOfRestaurants";
            this.ListOfRestaurants.Size = new System.Drawing.Size(400, 600);
            this.ListOfRestaurants.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListOfRestaurants.TabIndex = 1;
            this.ListOfRestaurants.UseCompatibleStateImageBehavior = false;
            this.ListOfRestaurants.View = System.Windows.Forms.View.Details;
            this.ListOfRestaurants.SelectedIndexChanged += new System.EventHandler(this.ListOfRestaurants_SelectedIndexChanged);
            // 
            // ListOfRestaurantsNames
            // 
            this.ListOfRestaurantsNames.Text = "Name";
            this.ListOfRestaurantsNames.Width = 395;
            // 
            // AddRestaurantButton
            // 
            this.AddRestaurantButton.BackColor = System.Drawing.Color.Silver;
            this.AddRestaurantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRestaurantButton.Location = new System.Drawing.Point(608, 446);
            this.AddRestaurantButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddRestaurantButton.Name = "AddRestaurantButton";
            this.AddRestaurantButton.Size = new System.Drawing.Size(300, 80);
            this.AddRestaurantButton.TabIndex = 3;
            this.AddRestaurantButton.Text = "Add Restaurant";
            this.AddRestaurantButton.UseVisualStyleBackColor = false;
            this.AddRestaurantButton.Click += new System.EventHandler(this.AddRestaurantButton_Click);
            // 
            // RestaurantNameTextbox
            // 
            this.RestaurantNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantNameTextbox.Location = new System.Drawing.Point(608, 392);
            this.RestaurantNameTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RestaurantNameTextbox.Name = "RestaurantNameTextbox";
            this.RestaurantNameTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantNameTextbox.TabIndex = 2;
            this.RestaurantNameTextbox.TextChanged += new System.EventHandler(this.RestaurantNameTextbox_TextChanged);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.BackColor = System.Drawing.Color.Silver;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenuButton.Location = new System.Drawing.Point(608, 538);
            this.BackToMainMenuButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(300, 80);
            this.BackToMainMenuButton.TabIndex = 4;
            this.BackToMainMenuButton.Text = "Back";
            this.BackToMainMenuButton.UseVisualStyleBackColor = false;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // SelectRestaurantMessageLabel
            // 
            this.SelectRestaurantMessageLabel.AutoSize = true;
            this.SelectRestaurantMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRestaurantMessageLabel.Location = new System.Drawing.Point(26, 17);
            this.SelectRestaurantMessageLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.SelectRestaurantMessageLabel.Name = "SelectRestaurantMessageLabel";
            this.SelectRestaurantMessageLabel.Size = new System.Drawing.Size(308, 25);
            this.SelectRestaurantMessageLabel.TabIndex = 5;
            this.SelectRestaurantMessageLabel.Text = "Select a Restaurant to view:";
            // 
            // RestaurantNameLabel
            // 
            this.RestaurantNameLabel.AutoSize = true;
            this.RestaurantNameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RestaurantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantNameLabel.Location = new System.Drawing.Point(603, 350);
            this.RestaurantNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.RestaurantNameLabel.Name = "RestaurantNameLabel";
            this.RestaurantNameLabel.Size = new System.Drawing.Size(264, 25);
            this.RestaurantNameLabel.TabIndex = 6;
            this.RestaurantNameLabel.Text = "Enter Restaurant Name:";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.Location = new System.Drawing.Point(445, 144);
            this.ErrorMessageLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(173, 25);
            this.ErrorMessageLabel.TabIndex = 7;
            this.ErrorMessageLabel.Text = "Error Message:";
            this.ErrorMessageLabel.Visible = false;
            // 
            // SysAdminRestaurantsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.RestaurantNameLabel);
            this.Controls.Add(this.SelectRestaurantMessageLabel);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.RestaurantNameTextbox);
            this.Controls.Add(this.AddRestaurantButton);
            this.Controls.Add(this.ListOfRestaurants);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SysAdminRestaurantsMenu";
            this.Text = "SysAdmin Menu: Restaurants";
            this.Load += new System.EventHandler(this.SysAdminRestaurantsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListOfRestaurants;
        private System.Windows.Forms.Button AddRestaurantButton;
        private System.Windows.Forms.TextBox RestaurantNameTextbox;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.Label SelectRestaurantMessageLabel;
        private System.Windows.Forms.Label RestaurantNameLabel;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.ColumnHeader ListOfRestaurantsNames;
    }
}