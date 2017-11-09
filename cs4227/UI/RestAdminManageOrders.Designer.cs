namespace cs4227.UI
{
    partial class RestAdminManageOrders
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
            this.CurrentOrdersLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.ViewOrderButton = new System.Windows.Forms.Button();
            this.CurrentOrders = new System.Windows.Forms.ListView();
            this.OrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cancelled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CurrentOrdersLabel
            // 
            this.CurrentOrdersLabel.AutoSize = true;
            this.CurrentOrdersLabel.Location = new System.Drawing.Point(12, 9);
            this.CurrentOrdersLabel.Name = "CurrentOrdersLabel";
            this.CurrentOrdersLabel.Size = new System.Drawing.Size(473, 25);
            this.CurrentOrdersLabel.TabIndex = 1;
            this.CurrentOrdersLabel.Text = "Current Orders: Select an Order to Process.";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Location = new System.Drawing.Point(672, 569);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(300, 80);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.BackColor = System.Drawing.Color.Silver;
            this.CancelOrderButton.Location = new System.Drawing.Point(343, 569);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(300, 80);
            this.CancelOrderButton.TabIndex = 2;
            this.CancelOrderButton.Text = "Cancel Order";
            this.CancelOrderButton.UseVisualStyleBackColor = false;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // ViewOrderButton
            // 
            this.ViewOrderButton.BackColor = System.Drawing.Color.Silver;
            this.ViewOrderButton.Location = new System.Drawing.Point(12, 569);
            this.ViewOrderButton.Name = "ViewOrderButton";
            this.ViewOrderButton.Size = new System.Drawing.Size(300, 80);
            this.ViewOrderButton.TabIndex = 1;
            this.ViewOrderButton.Text = "View Order";
            this.ViewOrderButton.UseVisualStyleBackColor = false;
            this.ViewOrderButton.Click += new System.EventHandler(this.ViewOrderButton_Click);
            // 
            // CurrentOrders
            // 
            this.CurrentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderId,
            this.User,
            this.Price,
            this.UserAddress,
            this.Cancelled});
            this.CurrentOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentOrders.FullRowSelect = true;
            this.CurrentOrders.HoverSelection = true;
            this.CurrentOrders.Location = new System.Drawing.Point(13, 45);
            this.CurrentOrders.MultiSelect = false;
            this.CurrentOrders.Name = "CurrentOrders";
            this.CurrentOrders.Size = new System.Drawing.Size(959, 518);
            this.CurrentOrders.TabIndex = 8;
            this.CurrentOrders.UseCompatibleStateImageBehavior = false;
            this.CurrentOrders.View = System.Windows.Forms.View.Details;
            this.CurrentOrders.SelectedIndexChanged += new System.EventHandler(this.CurrentOrders_SelectedIndexChanged);
            // 
            // OrderId
            // 
            this.OrderId.Text = "ID";
            this.OrderId.Width = 100;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 250;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // UserAddress
            // 
            this.UserAddress.Text = "Address";
            this.UserAddress.Width = 300;
            // 
            // Cancelled
            // 
            this.Cancelled.Text = "Cancelled";
            this.Cancelled.Width = 205;
            // 
            // RestAdminManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.CurrentOrders);
            this.Controls.Add(this.ViewOrderButton);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CurrentOrdersLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RestAdminManageOrders";
            this.Text = "RestAdmin Menu: Manage Orders";
            this.Load += new System.EventHandler(this.RestAdminManageOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CurrentOrdersLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.Button ViewOrderButton;
        private System.Windows.Forms.ListView CurrentOrders;
        private System.Windows.Forms.ColumnHeader OrderId;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Cancelled;
        private System.Windows.Forms.ColumnHeader UserAddress;
    }
}