namespace cs4227.UI
{
    partial class UserPlaceOrderMenu
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
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderPlacedLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.EDTLabel = new System.Windows.Forms.Label();
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Location = new System.Drawing.Point(361, 569);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(300, 80);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderPlacedLabel
            // 
            this.OrderPlacedLabel.AutoSize = true;
            this.OrderPlacedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPlacedLabel.Location = new System.Drawing.Point(58, 9);
            this.OrderPlacedLabel.Name = "OrderPlacedLabel";
            this.OrderPlacedLabel.Size = new System.Drawing.Size(871, 73);
            this.OrderPlacedLabel.TabIndex = 1;
            this.OrderPlacedLabel.Text = "Your Order has been Placed";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(303, 268);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(102, 37);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Time:";
            // 
            // EDTLabel
            // 
            this.EDTLabel.AutoSize = true;
            this.EDTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDTLabel.Location = new System.Drawing.Point(12, 336);
            this.EDTLabel.Name = "EDTLabel";
            this.EDTLabel.Size = new System.Drawing.Size(393, 37);
            this.EDTLabel.TabIndex = 3;
            this.EDTLabel.Text = "Estimated Delivery Time:";
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouLabel.Location = new System.Drawing.Point(280, 82);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(437, 39);
            this.ThankYouLabel.TabIndex = 4;
            this.ThankYouLabel.Text = "Thank You for Your Order";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(221, 203);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(184, 37);
            this.TotalCostLabel.TabIndex = 5;
            this.TotalCostLabel.Text = "Total Cost:";
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdLabel.Location = new System.Drawing.Point(248, 138);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(157, 37);
            this.OrderIdLabel.TabIndex = 6;
            this.OrderIdLabel.Text = "Order ID:";
            // 
            // UserPlaceOrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.OrderIdLabel);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Controls.Add(this.EDTLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.OrderPlacedLabel);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "UserPlaceOrderMenu";
            this.Text = "User Menu: Order Placed";
            this.Load += new System.EventHandler(this.UserPlaceOrderMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label OrderPlacedLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label EDTLabel;
        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label OrderIdLabel;
    }
}