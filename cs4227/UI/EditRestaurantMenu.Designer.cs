namespace cs4227.UI
{
    partial class EditRestaurantMenu
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
            this.RestaurantNameLabel = new System.Windows.Forms.Label();
            this.RestaurantNameTextbox = new System.Windows.Forms.TextBox();
            this.RestaurantAddressLabel = new System.Windows.Forms.Label();
            this.RestaurantAddressTextbox = new System.Windows.Forms.TextBox();
            this.RestaurantOwnerLabel = new System.Windows.Forms.Label();
            this.RestaurantOwnerTextbox = new System.Windows.Forms.TextBox();
            this.RestaurantPhoneNumberLabel = new System.Windows.Forms.Label();
            this.RestaurantPhoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.RestaurantEmailLabel = new System.Windows.Forms.Label();
            this.RestaurantEmailTextbox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.RestaurantOpeningHoursLabel = new System.Windows.Forms.Label();
            this.RestaurantOpeningHoursTextbox = new System.Windows.Forms.TextBox();
            this.RestaurantClosingHoursLabel = new System.Windows.Forms.Label();
            this.RestaurantClosingHoursTextbox = new System.Windows.Forms.TextBox();
            this.RestaurantDaysOpenLabel = new System.Windows.Forms.Label();
            this.RestaurantDaysOpenTextbox = new System.Windows.Forms.TextBox();
            this.RestaurantTypeLabel = new System.Windows.Forms.Label();
            this.RestaurantTypeTextbox = new System.Windows.Forms.TextBox();
            this.RestaurantDeliveryChargeLabel = new System.Windows.Forms.Label();
            this.RestaurantDeliveryChargeTextbox = new System.Windows.Forms.TextBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.OwnerUsernameLabel = new System.Windows.Forms.Label();
            this.RestaurantOwnerUsernameTextbox = new System.Windows.Forms.TextBox();
            this.DeleteRestaurantButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RestaurantNameLabel
            // 
            this.RestaurantNameLabel.AutoSize = true;
            this.RestaurantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantNameLabel.Location = new System.Drawing.Point(7, 9);
            this.RestaurantNameLabel.Name = "RestaurantNameLabel";
            this.RestaurantNameLabel.Size = new System.Drawing.Size(79, 25);
            this.RestaurantNameLabel.TabIndex = 0;
            this.RestaurantNameLabel.Text = "Name:";
            // 
            // RestaurantNameTextbox
            // 
            this.RestaurantNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantNameTextbox.Location = new System.Drawing.Point(12, 51);
            this.RestaurantNameTextbox.Name = "RestaurantNameTextbox";
            this.RestaurantNameTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantNameTextbox.TabIndex = 1;
            this.RestaurantNameTextbox.TextChanged += new System.EventHandler(this.RestaurantNameTextbox_TextChanged);
            // 
            // RestaurantAddressLabel
            // 
            this.RestaurantAddressLabel.AutoSize = true;
            this.RestaurantAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantAddressLabel.Location = new System.Drawing.Point(7, 85);
            this.RestaurantAddressLabel.Name = "RestaurantAddressLabel";
            this.RestaurantAddressLabel.Size = new System.Drawing.Size(105, 25);
            this.RestaurantAddressLabel.TabIndex = 2;
            this.RestaurantAddressLabel.Text = "Address:";
            // 
            // RestaurantAddressTextbox
            // 
            this.RestaurantAddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantAddressTextbox.Location = new System.Drawing.Point(12, 122);
            this.RestaurantAddressTextbox.Name = "RestaurantAddressTextbox";
            this.RestaurantAddressTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantAddressTextbox.TabIndex = 4;
            this.RestaurantAddressTextbox.TextChanged += new System.EventHandler(this.RestaurantAddressTextbox_TextChanged);
            // 
            // RestaurantOwnerLabel
            // 
            this.RestaurantOwnerLabel.AutoSize = true;
            this.RestaurantOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantOwnerLabel.Location = new System.Drawing.Point(7, 156);
            this.RestaurantOwnerLabel.Name = "RestaurantOwnerLabel";
            this.RestaurantOwnerLabel.Size = new System.Drawing.Size(86, 25);
            this.RestaurantOwnerLabel.TabIndex = 4;
            this.RestaurantOwnerLabel.Text = "Owner:";
            // 
            // RestaurantOwnerTextbox
            // 
            this.RestaurantOwnerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantOwnerTextbox.Location = new System.Drawing.Point(12, 193);
            this.RestaurantOwnerTextbox.Name = "RestaurantOwnerTextbox";
            this.RestaurantOwnerTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantOwnerTextbox.TabIndex = 7;
            this.RestaurantOwnerTextbox.TextChanged += new System.EventHandler(this.RestaurantOwnerTextbox_TextChanged);
            // 
            // RestaurantPhoneNumberLabel
            // 
            this.RestaurantPhoneNumberLabel.AutoSize = true;
            this.RestaurantPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantPhoneNumberLabel.Location = new System.Drawing.Point(7, 227);
            this.RestaurantPhoneNumberLabel.Name = "RestaurantPhoneNumberLabel";
            this.RestaurantPhoneNumberLabel.Size = new System.Drawing.Size(174, 25);
            this.RestaurantPhoneNumberLabel.TabIndex = 6;
            this.RestaurantPhoneNumberLabel.Text = "Phone Number:";
            // 
            // RestaurantPhoneNumberTextbox
            // 
            this.RestaurantPhoneNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantPhoneNumberTextbox.Location = new System.Drawing.Point(12, 264);
            this.RestaurantPhoneNumberTextbox.Name = "RestaurantPhoneNumberTextbox";
            this.RestaurantPhoneNumberTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantPhoneNumberTextbox.TabIndex = 10;
            this.RestaurantPhoneNumberTextbox.TextChanged += new System.EventHandler(this.RestaurantPhoneNumberTextbox_TextChanged);
            // 
            // RestaurantEmailLabel
            // 
            this.RestaurantEmailLabel.AutoSize = true;
            this.RestaurantEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantEmailLabel.Location = new System.Drawing.Point(336, 9);
            this.RestaurantEmailLabel.Name = "RestaurantEmailLabel";
            this.RestaurantEmailLabel.Size = new System.Drawing.Size(77, 25);
            this.RestaurantEmailLabel.TabIndex = 8;
            this.RestaurantEmailLabel.Text = "Email:";
            // 
            // RestaurantEmailTextbox
            // 
            this.RestaurantEmailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantEmailTextbox.Location = new System.Drawing.Point(341, 51);
            this.RestaurantEmailTextbox.Name = "RestaurantEmailTextbox";
            this.RestaurantEmailTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantEmailTextbox.TabIndex = 2;
            this.RestaurantEmailTextbox.TextChanged += new System.EventHandler(this.RestaurantEmailTextbox_TextChanged);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.Silver;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.Location = new System.Drawing.Point(12, 448);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(300, 185);
            this.SaveChangesButton.TabIndex = 12;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(672, 448);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(300, 185);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RestaurantOpeningHoursLabel
            // 
            this.RestaurantOpeningHoursLabel.AutoSize = true;
            this.RestaurantOpeningHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantOpeningHoursLabel.Location = new System.Drawing.Point(667, 9);
            this.RestaurantOpeningHoursLabel.Name = "RestaurantOpeningHoursLabel";
            this.RestaurantOpeningHoursLabel.Size = new System.Drawing.Size(176, 25);
            this.RestaurantOpeningHoursLabel.TabIndex = 12;
            this.RestaurantOpeningHoursLabel.Text = "Opening Hours:";
            // 
            // RestaurantOpeningHoursTextbox
            // 
            this.RestaurantOpeningHoursTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantOpeningHoursTextbox.Location = new System.Drawing.Point(672, 51);
            this.RestaurantOpeningHoursTextbox.Name = "RestaurantOpeningHoursTextbox";
            this.RestaurantOpeningHoursTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantOpeningHoursTextbox.TabIndex = 3;
            this.RestaurantOpeningHoursTextbox.TextChanged += new System.EventHandler(this.RestaurantOpeningHoursTextbox_TextChanged);
            // 
            // RestaurantClosingHoursLabel
            // 
            this.RestaurantClosingHoursLabel.AutoSize = true;
            this.RestaurantClosingHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantClosingHoursLabel.Location = new System.Drawing.Point(667, 85);
            this.RestaurantClosingHoursLabel.Name = "RestaurantClosingHoursLabel";
            this.RestaurantClosingHoursLabel.Size = new System.Drawing.Size(167, 25);
            this.RestaurantClosingHoursLabel.TabIndex = 14;
            this.RestaurantClosingHoursLabel.Text = "Closing Hours:";
            // 
            // RestaurantClosingHoursTextbox
            // 
            this.RestaurantClosingHoursTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantClosingHoursTextbox.Location = new System.Drawing.Point(672, 122);
            this.RestaurantClosingHoursTextbox.Name = "RestaurantClosingHoursTextbox";
            this.RestaurantClosingHoursTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantClosingHoursTextbox.TabIndex = 6;
            this.RestaurantClosingHoursTextbox.TextChanged += new System.EventHandler(this.RestaurantClosingHoursTextbox_TextChanged);
            // 
            // RestaurantDaysOpenLabel
            // 
            this.RestaurantDaysOpenLabel.AutoSize = true;
            this.RestaurantDaysOpenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantDaysOpenLabel.Location = new System.Drawing.Point(667, 156);
            this.RestaurantDaysOpenLabel.Name = "RestaurantDaysOpenLabel";
            this.RestaurantDaysOpenLabel.Size = new System.Drawing.Size(135, 25);
            this.RestaurantDaysOpenLabel.TabIndex = 16;
            this.RestaurantDaysOpenLabel.Text = "Days Open:";
            // 
            // RestaurantDaysOpenTextbox
            // 
            this.RestaurantDaysOpenTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantDaysOpenTextbox.Location = new System.Drawing.Point(672, 193);
            this.RestaurantDaysOpenTextbox.Name = "RestaurantDaysOpenTextbox";
            this.RestaurantDaysOpenTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantDaysOpenTextbox.TabIndex = 9;
            this.RestaurantDaysOpenTextbox.TextChanged += new System.EventHandler(this.RestaurantDaysOpenTextbox_TextChanged);
            // 
            // RestaurantTypeLabel
            // 
            this.RestaurantTypeLabel.AutoSize = true;
            this.RestaurantTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantTypeLabel.Location = new System.Drawing.Point(336, 156);
            this.RestaurantTypeLabel.Name = "RestaurantTypeLabel";
            this.RestaurantTypeLabel.Size = new System.Drawing.Size(71, 25);
            this.RestaurantTypeLabel.TabIndex = 18;
            this.RestaurantTypeLabel.Text = "Type:";
            // 
            // RestaurantTypeTextbox
            // 
            this.RestaurantTypeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantTypeTextbox.Location = new System.Drawing.Point(341, 193);
            this.RestaurantTypeTextbox.Name = "RestaurantTypeTextbox";
            this.RestaurantTypeTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantTypeTextbox.TabIndex = 8;
            this.RestaurantTypeTextbox.TextChanged += new System.EventHandler(this.RestaurantTypeTextbox_TextChanged);
            // 
            // RestaurantDeliveryChargeLabel
            // 
            this.RestaurantDeliveryChargeLabel.AutoSize = true;
            this.RestaurantDeliveryChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantDeliveryChargeLabel.Location = new System.Drawing.Point(336, 85);
            this.RestaurantDeliveryChargeLabel.Name = "RestaurantDeliveryChargeLabel";
            this.RestaurantDeliveryChargeLabel.Size = new System.Drawing.Size(180, 25);
            this.RestaurantDeliveryChargeLabel.TabIndex = 20;
            this.RestaurantDeliveryChargeLabel.Text = "Delivey Charge:";
            // 
            // RestaurantDeliveryChargeTextbox
            // 
            this.RestaurantDeliveryChargeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantDeliveryChargeTextbox.Location = new System.Drawing.Point(341, 122);
            this.RestaurantDeliveryChargeTextbox.Name = "RestaurantDeliveryChargeTextbox";
            this.RestaurantDeliveryChargeTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantDeliveryChargeTextbox.TabIndex = 5;
            this.RestaurantDeliveryChargeTextbox.Text = "0.00";
            this.RestaurantDeliveryChargeTextbox.TextChanged += new System.EventHandler(this.RestaurantDeliveryChargeTextbox_TextChanged);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.Location = new System.Drawing.Point(12, 364);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(173, 25);
            this.ErrorMessageLabel.TabIndex = 22;
            this.ErrorMessageLabel.Text = "Error Message:";
            this.ErrorMessageLabel.Visible = false;
            // 
            // OwnerUsernameLabel
            // 
            this.OwnerUsernameLabel.AutoSize = true;
            this.OwnerUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerUsernameLabel.Location = new System.Drawing.Point(336, 227);
            this.OwnerUsernameLabel.Name = "OwnerUsernameLabel";
            this.OwnerUsernameLabel.Size = new System.Drawing.Size(199, 25);
            this.OwnerUsernameLabel.TabIndex = 23;
            this.OwnerUsernameLabel.Text = "Owner Username:";
            // 
            // RestaurantOwnerUsernameTextbox
            // 
            this.RestaurantOwnerUsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantOwnerUsernameTextbox.Location = new System.Drawing.Point(341, 264);
            this.RestaurantOwnerUsernameTextbox.Name = "RestaurantOwnerUsernameTextbox";
            this.RestaurantOwnerUsernameTextbox.Size = new System.Drawing.Size(300, 31);
            this.RestaurantOwnerUsernameTextbox.TabIndex = 11;
            this.RestaurantOwnerUsernameTextbox.TextChanged += new System.EventHandler(this.OwnerUsernameTextbox_TextChanged);
            // 
            // DeleteRestaurantButton
            // 
            this.DeleteRestaurantButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteRestaurantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRestaurantButton.Location = new System.Drawing.Point(341, 448);
            this.DeleteRestaurantButton.Name = "DeleteRestaurantButton";
            this.DeleteRestaurantButton.Size = new System.Drawing.Size(300, 185);
            this.DeleteRestaurantButton.TabIndex = 13;
            this.DeleteRestaurantButton.Text = "Delete Restaurant";
            this.DeleteRestaurantButton.UseVisualStyleBackColor = false;
            this.DeleteRestaurantButton.Click += new System.EventHandler(this.DeleteRestaurantButton_Click);
            // 
            // EditRestaurantMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.DeleteRestaurantButton);
            this.Controls.Add(this.RestaurantOwnerUsernameTextbox);
            this.Controls.Add(this.OwnerUsernameLabel);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.RestaurantDeliveryChargeTextbox);
            this.Controls.Add(this.RestaurantDeliveryChargeLabel);
            this.Controls.Add(this.RestaurantTypeTextbox);
            this.Controls.Add(this.RestaurantTypeLabel);
            this.Controls.Add(this.RestaurantDaysOpenTextbox);
            this.Controls.Add(this.RestaurantDaysOpenLabel);
            this.Controls.Add(this.RestaurantClosingHoursTextbox);
            this.Controls.Add(this.RestaurantClosingHoursLabel);
            this.Controls.Add(this.RestaurantOpeningHoursTextbox);
            this.Controls.Add(this.RestaurantOpeningHoursLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.RestaurantEmailTextbox);
            this.Controls.Add(this.RestaurantEmailLabel);
            this.Controls.Add(this.RestaurantPhoneNumberTextbox);
            this.Controls.Add(this.RestaurantPhoneNumberLabel);
            this.Controls.Add(this.RestaurantOwnerTextbox);
            this.Controls.Add(this.RestaurantOwnerLabel);
            this.Controls.Add(this.RestaurantAddressTextbox);
            this.Controls.Add(this.RestaurantAddressLabel);
            this.Controls.Add(this.RestaurantNameTextbox);
            this.Controls.Add(this.RestaurantNameLabel);
            this.Name = "EditRestaurantMenu";
            this.Text = "Edit Restaurant";
            this.Load += new System.EventHandler(this.EditRestaurantMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RestaurantNameLabel;
        private System.Windows.Forms.TextBox RestaurantNameTextbox;
        private System.Windows.Forms.Label RestaurantAddressLabel;
        private System.Windows.Forms.TextBox RestaurantAddressTextbox;
        private System.Windows.Forms.Label RestaurantOwnerLabel;
        private System.Windows.Forms.TextBox RestaurantOwnerTextbox;
        private System.Windows.Forms.Label RestaurantPhoneNumberLabel;
        private System.Windows.Forms.TextBox RestaurantPhoneNumberTextbox;
        private System.Windows.Forms.Label RestaurantEmailLabel;
        private System.Windows.Forms.TextBox RestaurantEmailTextbox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label RestaurantOpeningHoursLabel;
        private System.Windows.Forms.TextBox RestaurantOpeningHoursTextbox;
        private System.Windows.Forms.Label RestaurantClosingHoursLabel;
        private System.Windows.Forms.TextBox RestaurantClosingHoursTextbox;
        private System.Windows.Forms.Label RestaurantDaysOpenLabel;
        private System.Windows.Forms.TextBox RestaurantDaysOpenTextbox;
        private System.Windows.Forms.Label RestaurantTypeLabel;
        private System.Windows.Forms.TextBox RestaurantTypeTextbox;
        private System.Windows.Forms.Label RestaurantDeliveryChargeLabel;
        private System.Windows.Forms.TextBox RestaurantDeliveryChargeTextbox;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Label OwnerUsernameLabel;
        private System.Windows.Forms.TextBox RestaurantOwnerUsernameTextbox;
        private System.Windows.Forms.Button DeleteRestaurantButton;
    }
}