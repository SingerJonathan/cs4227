namespace cs4227.UI
{
    partial class UserCheckout
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
            this.YourOrder = new System.Windows.Forms.ListView();
            this.OrderItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderItemDiscountedPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.YourOrderLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.DeliveryChargeLabel = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.OrderPriceLabel = new System.Windows.Forms.Label();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YourOrder
            // 
            this.YourOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderItemName,
            this.OrderItemPrice,
            this.OrderItemDiscountedPrice});
            this.YourOrder.Location = new System.Drawing.Point(16, 51);
            this.YourOrder.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.YourOrder.Name = "YourOrder";
            this.YourOrder.Size = new System.Drawing.Size(500, 595);
            this.YourOrder.TabIndex = 1;
            this.YourOrder.UseCompatibleStateImageBehavior = false;
            this.YourOrder.View = System.Windows.Forms.View.Details;
            // 
            // OrderItemName
            // 
            this.OrderItemName.Text = "Item";
            this.OrderItemName.Width = 210;
            // 
            // OrderItemPrice
            // 
            this.OrderItemPrice.Text = "Price";
            this.OrderItemPrice.Width = 80;
            // 
            // OrderItemDiscountedPrice
            // 
            this.OrderItemDiscountedPrice.Text = "Discounted Price";
            this.OrderItemDiscountedPrice.Width = 200;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(619, 333);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(117, 42);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "Total:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(626, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(626, 381);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 80);
            this.button2.TabIndex = 3;
            this.button2.Text = "Change Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YourOrderLabel
            // 
            this.YourOrderLabel.AutoSize = true;
            this.YourOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourOrderLabel.Location = new System.Drawing.Point(12, 9);
            this.YourOrderLabel.Name = "YourOrderLabel";
            this.YourOrderLabel.Size = new System.Drawing.Size(166, 31);
            this.YourOrderLabel.TabIndex = 5;
            this.YourOrderLabel.Text = "Your Order:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(626, 289);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(300, 31);
            this.AddressTextBox.TabIndex = 2;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(621, 247);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(296, 25);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "Enter Address for Delivery:";
            // 
            // DeliveryChargeLabel
            // 
            this.DeliveryChargeLabel.AutoSize = true;
            this.DeliveryChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryChargeLabel.Location = new System.Drawing.Point(619, 191);
            this.DeliveryChargeLabel.Name = "DeliveryChargeLabel";
            this.DeliveryChargeLabel.Size = new System.Drawing.Size(147, 37);
            this.DeliveryChargeLabel.TabIndex = 9;
            this.DeliveryChargeLabel.Text = "Delivery:";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(526, 69);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(173, 25);
            this.ErrorMessageLabel.TabIndex = 10;
            this.ErrorMessageLabel.Text = "Error Message:";
            // 
            // OrderPriceLabel
            // 
            this.OrderPriceLabel.AutoSize = true;
            this.OrderPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPriceLabel.Location = new System.Drawing.Point(328, 9);
            this.OrderPriceLabel.Name = "OrderPriceLabel";
            this.OrderPriceLabel.Size = new System.Drawing.Size(90, 31);
            this.OrderPriceLabel.TabIndex = 11;
            this.OrderPriceLabel.Text = "Price:";
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.BackColor = System.Drawing.Color.Silver;
            this.CancelOrderButton.Location = new System.Drawing.Point(626, 565);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(300, 80);
            this.CancelOrderButton.TabIndex = 12;
            this.CancelOrderButton.Text = "Cancel";
            this.CancelOrderButton.UseVisualStyleBackColor = false;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // UserCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.OrderPriceLabel);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.DeliveryChargeLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.YourOrderLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.YourOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "UserCheckout";
            this.Text = "User Menu: Checkout";
            this.Load += new System.EventHandler(this.UserCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView YourOrder;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label YourOrderLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label DeliveryChargeLabel;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.ColumnHeader OrderItemName;
        private System.Windows.Forms.ColumnHeader OrderItemPrice;
        private System.Windows.Forms.Label OrderPriceLabel;
        private System.Windows.Forms.ColumnHeader OrderItemDiscountedPrice;
        private System.Windows.Forms.Button CancelOrderButton;
    }
}