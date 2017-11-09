namespace cs4227.UI
{
    partial class SysAdminAuthentication
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
            this.TwoStepCodeTextBox = new System.Windows.Forms.TextBox();
            this.TwoStepAuthenticationLabel = new System.Windows.Forms.Label();
            this.EnterCodeLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TwoStepCodeTextBox
            // 
            this.TwoStepCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.TwoStepCodeTextBox.Location = new System.Drawing.Point(155, 280);
            this.TwoStepCodeTextBox.Name = "TwoStepCodeTextBox";
            this.TwoStepCodeTextBox.Size = new System.Drawing.Size(172, 53);
            this.TwoStepCodeTextBox.TabIndex = 1;
            this.TwoStepCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TwoStepCodeTextBox.TextChanged += new System.EventHandler(this.TwoStepCodeTextBox_TextChanged);
            // 
            // TwoStepAuthenticationLabel
            // 
            this.TwoStepAuthenticationLabel.AutoSize = true;
            this.TwoStepAuthenticationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.TwoStepAuthenticationLabel.Location = new System.Drawing.Point(4, 73);
            this.TwoStepAuthenticationLabel.Name = "TwoStepAuthenticationLabel";
            this.TwoStepAuthenticationLabel.Size = new System.Drawing.Size(477, 46);
            this.TwoStepAuthenticationLabel.TabIndex = 0;
            this.TwoStepAuthenticationLabel.Text = "Two Step Authentication";
            // 
            // EnterCodeLabel
            // 
            this.EnterCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.EnterCodeLabel.Location = new System.Drawing.Point(6, 182);
            this.EnterCodeLabel.Name = "EnterCodeLabel";
            this.EnterCodeLabel.Size = new System.Drawing.Size(477, 70);
            this.EnterCodeLabel.TabIndex = 1;
            this.EnterCodeLabel.Text = "Enter the code sent to the email associated with your account";
            this.EnterCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Silver;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(248, 369);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(224, 80);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 369);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(224, 80);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SysAdminAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.EnterCodeLabel);
            this.Controls.Add(this.TwoStepAuthenticationLabel);
            this.Controls.Add(this.TwoStepCodeTextBox);
            this.Name = "SysAdminAuthentication";
            this.Text = "System Admin Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TwoStepCodeTextBox;
        private System.Windows.Forms.Label TwoStepAuthenticationLabel;
        private System.Windows.Forms.Label EnterCodeLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button BackButton;
    }
}