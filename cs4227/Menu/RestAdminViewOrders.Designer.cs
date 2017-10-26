﻿namespace cs4227.Menu
{
    partial class RestAdminViewOrders
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " "}, -1);
            this.Order = new System.Windows.Forms.ListView();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.OrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cancelled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderId,
            this.User,
            this.Item0,
            this.Item1,
            this.Item2,
            this.Item3,
            this.Item4,
            this.Item5,
            this.Item6,
            this.Item7,
            this.Item8,
            this.Item9,
            this.Price,
            this.Address,
            this.Cancelled});
            this.Order.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Order.Location = new System.Drawing.Point(12, 12);
            this.Order.MultiSelect = false;
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(960, 420);
            this.Order.TabIndex = 0;
            this.Order.UseCompatibleStateImageBehavior = false;
            this.Order.View = System.Windows.Forms.View.Details;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Location = new System.Drawing.Point(604, 569);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(300, 80);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumberLabel.Location = new System.Drawing.Point(278, 469);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(339, 42);
            this.OrderNumberLabel.TabIndex = 2;
            this.OrderNumberLabel.Text = "Viewing Order No:";
            // 
            // OrderId
            // 
            this.OrderId.Text = "ID";
            this.OrderId.Width = 100;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 200;
            // 
            // Item0
            // 
            this.Item0.Text = "Item No:1";
            this.Item0.Width = 200;
            // 
            // Item1
            // 
            this.Item1.Text = "Item No:2";
            this.Item1.Width = 200;
            // 
            // Item2
            // 
            this.Item2.Text = "Item No:3";
            this.Item2.Width = 200;
            // 
            // Item3
            // 
            this.Item3.Text = "Item No:4";
            this.Item3.Width = 200;
            // 
            // Item4
            // 
            this.Item4.Text = "Item No:5";
            this.Item4.Width = 200;
            // 
            // Item5
            // 
            this.Item5.Text = "Item No:6";
            this.Item5.Width = 200;
            // 
            // Item6
            // 
            this.Item6.Text = "Item No:7";
            this.Item6.Width = 200;
            // 
            // Item7
            // 
            this.Item7.Text = "Item No:8";
            this.Item7.Width = 200;
            // 
            // Item8
            // 
            this.Item8.Text = "Item No:9";
            this.Item8.Width = 200;
            // 
            // Item9
            // 
            this.Item9.Text = "Item No:10";
            this.Item9.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Price: €";
            this.Price.Width = 100;
            // 
            // Address
            // 
            this.Address.Text = "Address:";
            this.Address.Width = 300;
            // 
            // Cancelled
            // 
            this.Cancelled.Text = "Cancelled";
            this.Cancelled.Width = 200;
            // 
            // RestAdminViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Order);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RestAdminViewOrders";
            this.Text = "RestAdmin Menu: View Orders";
            this.Load += new System.EventHandler(this.RestAdminViewOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Order;
        private System.Windows.Forms.ColumnHeader OrderId;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Item0;
        private System.Windows.Forms.ColumnHeader Item1;
        private System.Windows.Forms.ColumnHeader Item2;
        private System.Windows.Forms.ColumnHeader Item3;
        private System.Windows.Forms.ColumnHeader Item4;
        private System.Windows.Forms.ColumnHeader Item5;
        private System.Windows.Forms.ColumnHeader Item6;
        private System.Windows.Forms.ColumnHeader Item7;
        private System.Windows.Forms.ColumnHeader Item8;
        private System.Windows.Forms.ColumnHeader Item9;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Cancelled;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label OrderNumberLabel;
    }
}