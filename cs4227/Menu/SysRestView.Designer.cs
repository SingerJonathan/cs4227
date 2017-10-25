namespace cs4227.Menu
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditRestaurantButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(591, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "View order logs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(95, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(591, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(95, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(591, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Menu Item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Restaraunt viewing menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditRestaurantButton
            // 
            this.EditRestaurantButton.BackColor = System.Drawing.Color.Silver;
            this.EditRestaurantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRestaurantButton.Location = new System.Drawing.Point(95, 263);
            this.EditRestaurantButton.Name = "EditRestaurantButton";
            this.EditRestaurantButton.Size = new System.Drawing.Size(591, 47);
            this.EditRestaurantButton.TabIndex = 4;
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
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SysViewRestaraunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(774, 575);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditRestaurantButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditRestaurantButton;
        private System.Windows.Forms.Button BackButton;
    }
}