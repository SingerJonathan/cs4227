namespace cs4227.UI
{
    partial class SysViewRestaraunt
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
            this.RestaurantViewingMenuLabel = new System.Windows.Forms.Label();
            this.EditRestaurantButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.RestaurantNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(591, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "View order logs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(95, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(591, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RestaurantViewingMenuLabel
            // 
            this.RestaurantViewingMenuLabel.AutoSize = true;
            this.RestaurantViewingMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantViewingMenuLabel.Location = new System.Drawing.Point(96, 9);
            this.RestaurantViewingMenuLabel.Name = "RestaurantViewingMenuLabel";
            this.RestaurantViewingMenuLabel.Size = new System.Drawing.Size(598, 55);
            this.RestaurantViewingMenuLabel.TabIndex = 3;
            this.RestaurantViewingMenuLabel.Text = "Restaraunt Viewing Menu";
            // 
            // EditRestaurantButton
            // 
            this.EditRestaurantButton.BackColor = System.Drawing.Color.Silver;
            this.EditRestaurantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRestaurantButton.Location = new System.Drawing.Point(95, 291);
            this.EditRestaurantButton.Name = "EditRestaurantButton";
            this.EditRestaurantButton.Size = new System.Drawing.Size(591, 47);
            this.EditRestaurantButton.TabIndex = 2;
            this.EditRestaurantButton.Text = "Edit Restaurant Details";
            this.EditRestaurantButton.UseVisualStyleBackColor = false;
            this.EditRestaurantButton.Click += new System.EventHandler(this.EditRestaurantButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(95, 493);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(591, 47);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RestaurantNameLabel
            // 
            this.RestaurantNameLabel.AutoSize = true;
            this.RestaurantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantNameLabel.Location = new System.Drawing.Point(12, 100);
            this.RestaurantNameLabel.Name = "RestaurantNameLabel";
            this.RestaurantNameLabel.Size = new System.Drawing.Size(134, 25);
            this.RestaurantNameLabel.TabIndex = 6;
            this.RestaurantNameLabel.Text = "Restaurant:";
            // 
            // SysViewRestaraunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(774, 575);
            this.Controls.Add(this.RestaurantNameLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditRestaurantButton);
            this.Controls.Add(this.RestaurantViewingMenuLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SysViewRestaraunt";
            this.Text = "View Resteraunts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label RestaurantViewingMenuLabel;
        private System.Windows.Forms.Button EditRestaurantButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label RestaurantNameLabel;
    }
}