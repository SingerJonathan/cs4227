namespace cs4227.Menu
{
    partial class UserOrderHistory
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
            this.OrderHistoryLabel = new System.Windows.Forms.Label();
            this.Orders = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Restaurant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(631, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(631, 474);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Order";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(631, 566);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OrderHistoryLabel
            // 
            this.OrderHistoryLabel.AutoSize = true;
            this.OrderHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderHistoryLabel.Location = new System.Drawing.Point(16, 9);
            this.OrderHistoryLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.OrderHistoryLabel.Name = "OrderHistoryLabel";
            this.OrderHistoryLabel.Size = new System.Drawing.Size(454, 31);
            this.OrderHistoryLabel.TabIndex = 4;
            this.OrderHistoryLabel.Text = "Select an Order from Your History";
            // 
            // Orders
            // 
            this.Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Restaurant,
            this.Cost});
            this.Orders.HoverSelection = true;
            this.Orders.Location = new System.Drawing.Point(12, 43);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(609, 606);
            this.Orders.TabIndex = 5;
            this.Orders.UseCompatibleStateImageBehavior = false;
            this.Orders.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 80;
            // 
            // Restaurant
            // 
            this.Restaurant.Text = "Restaurant";
            this.Restaurant.Width = 300;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 100;
            // 
            // UserOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.OrderHistoryLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "UserOrderHistory";
            this.Text = "User Menu: Order History:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label OrderHistoryLabel;
        private System.Windows.Forms.ListView Orders;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Restaurant;
        private System.Windows.Forms.ColumnHeader Cost;
    }
}