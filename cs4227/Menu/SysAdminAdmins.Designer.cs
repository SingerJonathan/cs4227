﻿namespace cs4227.Menu
{
    partial class SysAdminAdminsMenu
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "JohnConnor@emailaddress.com"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "SteveBowland@emailaddress.com"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.AdminsList = new System.Windows.Forms.ListView();
            this.AddAdminButton = new System.Windows.Forms.Button();
            this.AdminEmailTextbox = new System.Windows.Forms.TextBox();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.AdminEmailLabel = new System.Windows.Forms.Label();
            this.SelectAdminMessageLabel = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminsList
            // 
            this.AdminsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.AdminsList.Location = new System.Drawing.Point(13, 54);
            this.AdminsList.MultiSelect = false;
            this.AdminsList.Name = "AdminsList";
            this.AdminsList.Size = new System.Drawing.Size(400, 596);
            this.AdminsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AdminsList.TabIndex = 0;
            this.AdminsList.UseCompatibleStateImageBehavior = false;
            this.AdminsList.View = System.Windows.Forms.View.List;
            this.AdminsList.SelectedIndexChanged += new System.EventHandler(this.AdminsList_SelectedIndexChanged);
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.BackColor = System.Drawing.Color.Silver;
            this.AddAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminButton.Location = new System.Drawing.Point(570, 427);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(350, 80);
            this.AddAdminButton.TabIndex = 2;
            this.AddAdminButton.Text = "Add Admin";
            this.AddAdminButton.UseVisualStyleBackColor = false;
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // AdminEmailTextbox
            // 
            this.AdminEmailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminEmailTextbox.Location = new System.Drawing.Point(570, 390);
            this.AdminEmailTextbox.Name = "AdminEmailTextbox";
            this.AdminEmailTextbox.Size = new System.Drawing.Size(350, 31);
            this.AdminEmailTextbox.TabIndex = 7;
            this.AdminEmailTextbox.TextChanged += new System.EventHandler(this.AdminEmailTextbox_TextChanged);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.BackColor = System.Drawing.Color.Silver;
            this.BackToMainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenuButton.Location = new System.Drawing.Point(570, 513);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(350, 80);
            this.BackToMainMenuButton.TabIndex = 11;
            this.BackToMainMenuButton.Text = "Back";
            this.BackToMainMenuButton.UseVisualStyleBackColor = false;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // AdminEmailLabel
            // 
            this.AdminEmailLabel.AutoSize = true;
            this.AdminEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminEmailLabel.Location = new System.Drawing.Point(565, 352);
            this.AdminEmailLabel.Name = "AdminEmailLabel";
            this.AdminEmailLabel.Size = new System.Drawing.Size(140, 25);
            this.AdminEmailLabel.TabIndex = 14;
            this.AdminEmailLabel.Text = "Enter Email:";
            // 
            // SelectAdminMessageLabel
            // 
            this.SelectAdminMessageLabel.AutoSize = true;
            this.SelectAdminMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAdminMessageLabel.Location = new System.Drawing.Point(12, 9);
            this.SelectAdminMessageLabel.Name = "SelectAdminMessageLabel";
            this.SelectAdminMessageLabel.Size = new System.Drawing.Size(271, 25);
            this.SelectAdminMessageLabel.TabIndex = 16;
            this.SelectAdminMessageLabel.Text = "Select an Admin to view:";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.Location = new System.Drawing.Point(419, 245);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(166, 25);
            this.ErrorMessageLabel.TabIndex = 17;
            this.ErrorMessageLabel.Text = "Error Message";
            this.ErrorMessageLabel.Visible = false;
            // 
            // SysAdminAdminsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.SelectAdminMessageLabel);
            this.Controls.Add(this.AdminEmailLabel);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.AdminEmailTextbox);
            this.Controls.Add(this.AddAdminButton);
            this.Controls.Add(this.AdminsList);
            this.Name = "SysAdminAdminsMenu";
            this.Text = "SysAdmin Menu: Admins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AdminsList;
        private System.Windows.Forms.Button AddAdminButton;
        private System.Windows.Forms.TextBox AdminEmailTextbox;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.Label AdminEmailLabel;
        private System.Windows.Forms.Label SelectAdminMessageLabel;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}