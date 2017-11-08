namespace cs4227.UI
{
    partial class LoginMenuV2
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
            this.WelcomeMessageLabel = new System.Windows.Forms.Label();
            this.LoginMessageLabel = new System.Windows.Forms.Label();
            this.DisplayDateLabel = new System.Windows.Forms.Label();
            this.DisplayTimeLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // WelcomeMessageLabel
            // 
            this.WelcomeMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessageLabel.Location = new System.Drawing.Point(0, 38);
            this.WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            this.WelcomeMessageLabel.Size = new System.Drawing.Size(983, 137);
            this.WelcomeMessageLabel.TabIndex = 2;
            this.WelcomeMessageLabel.Text = "Welcome to Tap and Eat!";
            this.WelcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginMessageLabel
            // 
            this.LoginMessageLabel.AutoSize = true;
            this.LoginMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMessageLabel.Location = new System.Drawing.Point(333, 175);
            this.LoginMessageLabel.Name = "LoginMessageLabel";
            this.LoginMessageLabel.Size = new System.Drawing.Size(288, 33);
            this.LoginMessageLabel.TabIndex = 3;
            this.LoginMessageLabel.Text = "Please Login Below";
            // 
            // DisplayDateLabel
            // 
            this.DisplayDateLabel.AutoSize = true;
            this.DisplayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayDateLabel.Location = new System.Drawing.Point(13, 13);
            this.DisplayDateLabel.Name = "DisplayDateLabel";
            this.DisplayDateLabel.Size = new System.Drawing.Size(68, 25);
            this.DisplayDateLabel.TabIndex = 0;
            this.DisplayDateLabel.Text = "Date:";
            // 
            // DisplayTimeLabel
            // 
            this.DisplayTimeLabel.AutoSize = true;
            this.DisplayTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTimeLabel.Location = new System.Drawing.Point(685, 13);
            this.DisplayTimeLabel.Name = "DisplayTimeLabel";
            this.DisplayTimeLabel.Size = new System.Drawing.Size(155, 25);
            this.DisplayTimeLabel.TabIndex = 1;
            this.DisplayTimeLabel.Text = "Current Time:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Silver;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(339, 483);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(300, 80);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.Location = new System.Drawing.Point(339, 345);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(300, 31);
            this.PasswordTextbox.TabIndex = 8;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.Location = new System.Drawing.Point(339, 259);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(300, 31);
            this.UsernameTextbox.TabIndex = 7;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(334, 307);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(121, 25);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(334, 219);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(125, 25);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username:";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.Location = new System.Drawing.Point(101, 403);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(173, 25);
            this.ErrorMessageLabel.TabIndex = 6;
            this.ErrorMessageLabel.Text = "Error Message:";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Silver;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(339, 569);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(300, 80);
            this.SignUpButton.TabIndex = 11;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(646, 345);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(197, 29);
            this.ShowPasswordCheckBox.TabIndex = 9;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // LoginMenuV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.DisplayTimeLabel);
            this.Controls.Add(this.DisplayDateLabel);
            this.Controls.Add(this.LoginMessageLabel);
            this.Controls.Add(this.WelcomeMessageLabel);
            this.Name = "LoginMenuV2";
            this.Text = "Tap And Eat: Login Menu";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessageLabel;
        private System.Windows.Forms.Label LoginMessageLabel;
        private System.Windows.Forms.Label DisplayDateLabel;
        private System.Windows.Forms.Label DisplayTimeLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
    }
}