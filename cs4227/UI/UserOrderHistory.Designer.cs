namespace cs4227.UI
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
            this.button3 = new System.Windows.Forms.Button();
            this.OrderHistoryLabel = new System.Windows.Forms.Label();
            this.UserOrders = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item00 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item03 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item04 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item05 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item06 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item07 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.useraddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(389, 566);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 80);
            this.button3.TabIndex = 2;
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
            // UserOrders
            // 
            this.UserOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.rest,
            this.Item00,
            this.Item01,
            this.Item02,
            this.Item03,
            this.Item04,
            this.Item05,
            this.Item06,
            this.Item07,
            this.price,
            this.useraddress,
            this.cancelled});
            this.UserOrders.FullRowSelect = true;
            this.UserOrders.HoverSelection = true;
            this.UserOrders.Location = new System.Drawing.Point(12, 43);
            this.UserOrders.Name = "UserOrders";
            this.UserOrders.Size = new System.Drawing.Size(960, 491);
            this.UserOrders.TabIndex = 1;
            this.UserOrders.UseCompatibleStateImageBehavior = false;
            this.UserOrders.View = System.Windows.Forms.View.Details;
            this.UserOrders.SelectedIndexChanged += new System.EventHandler(this.Orders_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 80;
            // 
            // rest
            // 
            this.rest.Text = "Restaurant";
            this.rest.Width = 200;
            // 
            // Item00
            // 
            this.Item00.Text = "Items";
            this.Item00.Width = 200;
            // 
            // Item01
            // 
            this.Item01.Text = "";
            this.Item01.Width = 200;
            // 
            // Item02
            // 
            this.Item02.Text = "";
            this.Item02.Width = 200;
            // 
            // Item03
            // 
            this.Item03.Text = "";
            this.Item03.Width = 200;
            // 
            // Item04
            // 
            this.Item04.Text = "";
            this.Item04.Width = 200;
            // 
            // Item05
            // 
            this.Item05.Text = "";
            this.Item05.Width = 200;
            // 
            // Item06
            // 
            this.Item06.Text = "";
            this.Item06.Width = 200;
            // 
            // Item07
            // 
            this.Item07.Text = "";
            this.Item07.Width = 200;
            // 
            // price
            // 
            this.price.Text = "Cost";
            this.price.Width = 200;
            // 
            // useraddress
            // 
            this.useraddress.Text = "Address";
            this.useraddress.Width = 200;
            // 
            // cancelled
            // 
            this.cancelled.Text = "Cancelled";
            this.cancelled.Width = 200;
            // 
            // UserOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.UserOrders);
            this.Controls.Add(this.OrderHistoryLabel);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "UserOrderHistory";
            this.Text = "User Menu: Order History:";
            this.Load += new System.EventHandler(this.UserOrderHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label OrderHistoryLabel;
        private System.Windows.Forms.ListView UserOrders;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader rest;
        private System.Windows.Forms.ColumnHeader Item00;
        private System.Windows.Forms.ColumnHeader Item01;
        private System.Windows.Forms.ColumnHeader Item02;
        private System.Windows.Forms.ColumnHeader Item03;
        private System.Windows.Forms.ColumnHeader Item04;
        private System.Windows.Forms.ColumnHeader Item05;
        private System.Windows.Forms.ColumnHeader Item06;
        private System.Windows.Forms.ColumnHeader Item07;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader useraddress;
        private System.Windows.Forms.ColumnHeader cancelled;
    }
}