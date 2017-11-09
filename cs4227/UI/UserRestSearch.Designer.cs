namespace cs4227.UI
{
    partial class UserRestarauntSearch
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
            this.ListOfRestaurants = new System.Windows.Forms.ListView();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.EnterRestaurantName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfRestaurants
            // 
            this.ListOfRestaurants.Location = new System.Drawing.Point(16, 46);
            this.ListOfRestaurants.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ListOfRestaurants.Name = "ListOfRestaurants";
            this.ListOfRestaurants.Size = new System.Drawing.Size(500, 600);
            this.ListOfRestaurants.TabIndex = 1;
            this.ListOfRestaurants.UseCompatibleStateImageBehavior = false;
            this.ListOfRestaurants.View = System.Windows.Forms.View.List;
            this.ListOfRestaurants.SelectedIndexChanged += new System.EventHandler(this.ListOfRestaurants_SelectedIndexChanged);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(618, 323);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(300, 31);
            this.SearchTextbox.TabIndex = 2;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // EnterRestaurantName
            // 
            this.EnterRestaurantName.AutoSize = true;
            this.EnterRestaurantName.Location = new System.Drawing.Point(613, 283);
            this.EnterRestaurantName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.EnterRestaurantName.Name = "EnterRestaurantName";
            this.EnterRestaurantName.Size = new System.Drawing.Size(264, 25);
            this.EnterRestaurantName.TabIndex = 2;
            this.EnterRestaurantName.Text = "Enter Restaurant Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(797, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a Restaurant from the List below or Enter the name of a Restaurant:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(618, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(618, 566);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 80);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(527, 385);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(173, 25);
            this.ErrorMessageLabel.TabIndex = 6;
            this.ErrorMessageLabel.Text = "Error Message:";
            // 
            // UserRestarauntSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterRestaurantName);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.ListOfRestaurants);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "UserRestarauntSearch";
            this.Text = "User Menu: Search for Restaurant";
            this.Load += new System.EventHandler(this.UserResterauntSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListOfRestaurants;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Label EnterRestaurantName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}