namespace cs4227.UI
{
    partial class RestAdminViewMenu
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
            this.SelectMenuItemLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RestaurantMenuList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BronzeDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SilverDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoldDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditItemButton = new System.Windows.Forms.Button();
            this.BronzeDiscountTextbox = new System.Windows.Forms.TextBox();
            this.BronzeDiscountLabel = new System.Windows.Forms.Label();
            this.SilverDiscountLabel = new System.Windows.Forms.Label();
            this.GoldDiscountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectMenuItemLabel
            // 
            this.SelectMenuItemLabel.AutoSize = true;
            this.SelectMenuItemLabel.Location = new System.Drawing.Point(13, 13);
            this.SelectMenuItemLabel.Name = "SelectMenuItemLabel";
            this.SelectMenuItemLabel.Size = new System.Drawing.Size(309, 25);
            this.SelectMenuItemLabel.TabIndex = 1;
            this.SelectMenuItemLabel.Text = "Select Item from List to Edit:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Location = new System.Drawing.Point(778, 569);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(146, 80);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.Silver;
            this.AddItemButton.Location = new System.Drawing.Point(624, 477);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(148, 86);
            this.AddItemButton.TabIndex = 4;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(624, 225);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(300, 31);
            this.PriceTextbox.TabIndex = 2;
            this.PriceTextbox.TextChanged += new System.EventHandler(this.PriceTextbox_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(619, 187);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(73, 25);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Price:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(624, 153);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(300, 31);
            this.NameTextbox.TabIndex = 1;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(619, 115);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 25);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // RestaurantMenuList
            // 
            this.RestaurantMenuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FoodName,
            this.Cost,
            this.BronzeDiscount,
            this.SilverDiscount,
            this.GoldDiscount});
            this.RestaurantMenuList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestaurantMenuList.FullRowSelect = true;
            this.RestaurantMenuList.Location = new System.Drawing.Point(12, 49);
            this.RestaurantMenuList.Name = "RestaurantMenuList";
            this.RestaurantMenuList.Size = new System.Drawing.Size(526, 600);
            this.RestaurantMenuList.TabIndex = 10;
            this.RestaurantMenuList.UseCompatibleStateImageBehavior = false;
            this.RestaurantMenuList.View = System.Windows.Forms.View.Details;
            this.RestaurantMenuList.SelectedIndexChanged += new System.EventHandler(this.RestaurantMenuList_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 75;
            // 
            // FoodName
            // 
            this.FoodName.Text = "Name";
            this.FoodName.Width = 300;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 100;
            // 
            // BronzeDiscount
            // 
            this.BronzeDiscount.Text = "Bronze Discount";
            this.BronzeDiscount.Width = 200;
            // 
            // SilverDiscount
            // 
            this.SilverDiscount.Text = "Silver Discount";
            this.SilverDiscount.Width = 200;
            // 
            // GoldDiscount
            // 
            this.GoldDiscount.Text = "Gold Discount";
            this.GoldDiscount.Width = 200;
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(544, 49);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(173, 25);
            this.ErrorMessageLabel.TabIndex = 9;
            this.ErrorMessageLabel.Text = "Error Message:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Silver;
            this.RemoveButton.Location = new System.Drawing.Point(624, 569);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(148, 80);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditItemButton
            // 
            this.EditItemButton.BackColor = System.Drawing.Color.Silver;
            this.EditItemButton.Location = new System.Drawing.Point(778, 477);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.Size = new System.Drawing.Size(146, 86);
            this.EditItemButton.TabIndex = 5;
            this.EditItemButton.Text = "Edit Item";
            this.EditItemButton.UseVisualStyleBackColor = false;
            this.EditItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // BronzeDiscountTextbox
            // 
            this.BronzeDiscountTextbox.Location = new System.Drawing.Point(624, 296);
            this.BronzeDiscountTextbox.Name = "BronzeDiscountTextbox";
            this.BronzeDiscountTextbox.Size = new System.Drawing.Size(300, 31);
            this.BronzeDiscountTextbox.TabIndex = 3;
            this.BronzeDiscountTextbox.Text = "0.00";
            this.BronzeDiscountTextbox.TextChanged += new System.EventHandler(this.BronzeDiscountTextbox_TextChanged);
            // 
            // BronzeDiscountLabel
            // 
            this.BronzeDiscountLabel.AutoSize = true;
            this.BronzeDiscountLabel.Location = new System.Drawing.Point(619, 259);
            this.BronzeDiscountLabel.Name = "BronzeDiscountLabel";
            this.BronzeDiscountLabel.Size = new System.Drawing.Size(192, 25);
            this.BronzeDiscountLabel.TabIndex = 15;
            this.BronzeDiscountLabel.Text = "Bronze Discount:";
            // 
            // SilverDiscountLabel
            // 
            this.SilverDiscountLabel.AutoSize = true;
            this.SilverDiscountLabel.Location = new System.Drawing.Point(619, 371);
            this.SilverDiscountLabel.Name = "SilverDiscountLabel";
            this.SilverDiscountLabel.Size = new System.Drawing.Size(231, 25);
            this.SilverDiscountLabel.TabIndex = 17;
            this.SilverDiscountLabel.Text = "Silver Discount: 0.00";
            // 
            // GoldDiscountLabel
            // 
            this.GoldDiscountLabel.AutoSize = true;
            this.GoldDiscountLabel.Location = new System.Drawing.Point(619, 427);
            this.GoldDiscountLabel.Name = "GoldDiscountLabel";
            this.GoldDiscountLabel.Size = new System.Drawing.Size(220, 25);
            this.GoldDiscountLabel.TabIndex = 19;
            this.GoldDiscountLabel.Text = "Gold Discount: 0.00";
            // 
            // RestAdminViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.GoldDiscountLabel);
            this.Controls.Add(this.SilverDiscountLabel);
            this.Controls.Add(this.BronzeDiscountLabel);
            this.Controls.Add(this.BronzeDiscountTextbox);
            this.Controls.Add(this.EditItemButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.RestaurantMenuList);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SelectMenuItemLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RestAdminViewMenu";
            this.Text = "RestAdmin Menu: View Menu";
            this.Load += new System.EventHandler(this.RestAdminViewMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SelectMenuItemLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListView RestaurantMenuList;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FoodName;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Button EditItemButton;
        private System.Windows.Forms.ColumnHeader BronzeDiscount;
        private System.Windows.Forms.ColumnHeader SilverDiscount;
        private System.Windows.Forms.ColumnHeader GoldDiscount;
        private System.Windows.Forms.TextBox BronzeDiscountTextbox;
        private System.Windows.Forms.Label BronzeDiscountLabel;
        private System.Windows.Forms.Label SilverDiscountLabel;
        private System.Windows.Forms.Label GoldDiscountLabel;
    }
}