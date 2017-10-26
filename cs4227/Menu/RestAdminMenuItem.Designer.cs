namespace cs4227.Menu
{
    partial class RestAdminMenuItem
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
            this.BackButton.Location = new System.Drawing.Point(624, 569);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(300, 80);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.Silver;
            this.AddItemButton.Location = new System.Drawing.Point(624, 460);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(300, 86);
            this.AddItemButton.TabIndex = 3;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(624, 373);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(300, 31);
            this.PriceTextbox.TabIndex = 4;
            this.PriceTextbox.TextChanged += new System.EventHandler(this.PriceTextbox_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(619, 332);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(73, 25);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Price:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(624, 287);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(300, 31);
            this.NameTextbox.TabIndex = 6;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(619, 247);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 25);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // RestaurantMenuList
            // 
            this.RestaurantMenuList.Location = new System.Drawing.Point(12, 49);
            this.RestaurantMenuList.Name = "RestaurantMenuList";
            this.RestaurantMenuList.Size = new System.Drawing.Size(500, 600);
            this.RestaurantMenuList.TabIndex = 8;
            this.RestaurantMenuList.UseCompatibleStateImageBehavior = false;
            this.RestaurantMenuList.SelectedIndexChanged += new System.EventHandler(this.RestaurantMenuList_SelectedIndexChanged);
            // 
            // RestAdminMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
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
            this.Name = "RestAdminMenuItem";
            this.Text = "RestAdmin Menu: View Menu";
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
    }
}