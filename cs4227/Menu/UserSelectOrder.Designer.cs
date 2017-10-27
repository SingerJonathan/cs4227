﻿namespace cs4227.Menu
{
    partial class UserOrderMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.YourOrderLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RestaurantMenu = new System.Windows.Forms.ListView();
            this.YourOrder = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurant Menu:";
            // 
            // YourOrderLabel
            // 
            this.YourOrderLabel.AutoSize = true;
            this.YourOrderLabel.Location = new System.Drawing.Point(513, 9);
            this.YourOrderLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.YourOrderLabel.Name = "YourOrderLabel";
            this.YourOrderLabel.Size = new System.Drawing.Size(135, 25);
            this.YourOrderLabel.TabIndex = 3;
            this.YourOrderLabel.Text = "Your Order:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 563);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Click item to add to menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 563);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Click item to delete from order";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(518, 602);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(303, 602);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Checkout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RestaurantMenu
            // 
            this.RestaurantMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestaurantMenu.Location = new System.Drawing.Point(12, 38);
            this.RestaurantMenu.MultiSelect = false;
            this.RestaurantMenu.Name = "RestaurantMenu";
            this.RestaurantMenu.Size = new System.Drawing.Size(454, 522);
            this.RestaurantMenu.TabIndex = 8;
            this.RestaurantMenu.UseCompatibleStateImageBehavior = false;
            this.RestaurantMenu.SelectedIndexChanged += new System.EventHandler(this.RestaurantMenu_SelectedIndexChanged);
            // 
            // YourOrder
            // 
            this.YourOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YourOrder.Location = new System.Drawing.Point(518, 38);
            this.YourOrder.MultiSelect = false;
            this.YourOrder.Name = "YourOrder";
            this.YourOrder.Size = new System.Drawing.Size(454, 522);
            this.YourOrder.TabIndex = 9;
            this.YourOrder.UseCompatibleStateImageBehavior = false;
            this.YourOrder.SelectedIndexChanged += new System.EventHandler(this.YourOrder_SelectedIndexChanged);
            // 
            // UserOrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.YourOrder);
            this.Controls.Add(this.RestaurantMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YourOrderLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "UserOrderMenu";
            this.Text = "User Menu: Select Order";
            this.Load += new System.EventHandler(this.UserOrderMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YourOrderLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView RestaurantMenu;
        private System.Windows.Forms.ListView YourOrder;
    }
}