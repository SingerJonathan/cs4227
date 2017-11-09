namespace cs4227.UI
{
    partial class SysViewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Logs";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.username,
            this.item0,
            this.item1,
            this.item2,
            this.item3,
            this.item4,
            this.item5,
            this.item6,
            this.item7,
            this.cost,
            this.address,
            this.cancelled});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.listView.Location = new System.Drawing.Point(12, 79);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(960, 466);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 120;
            // 
            // item0
            // 
            this.item0.Text = "Items";
            this.item0.Width = 80;
            // 
            // item1
            // 
            this.item1.Text = "";
            this.item1.Width = 80;
            // 
            // item2
            // 
            this.item2.Text = "";
            this.item2.Width = 80;
            // 
            // item3
            // 
            this.item3.Text = "";
            this.item3.Width = 80;
            // 
            // item4
            // 
            this.item4.Text = "";
            this.item4.Width = 80;
            // 
            // item5
            // 
            this.item5.Text = "";
            this.item5.Width = 80;
            // 
            // item6
            // 
            this.item6.Text = "";
            this.item6.Width = 80;
            // 
            // item7
            // 
            this.item7.Text = "";
            this.item7.Width = 80;
            // 
            // cost
            // 
            this.cost.Text = "Price";
            this.cost.Width = 80;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 120;
            // 
            // cancelled
            // 
            this.cancelled.Text = "Cancelled";
            this.cancelled.Width = 120;
            // 
            // SysViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SysViewOrder";
            this.Text = "SysAdmin Menu: View Logs";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader item0;
        private System.Windows.Forms.ColumnHeader item1;
        private System.Windows.Forms.ColumnHeader item2;
        private System.Windows.Forms.ColumnHeader item3;
        private System.Windows.Forms.ColumnHeader item4;
        private System.Windows.Forms.ColumnHeader item5;
        private System.Windows.Forms.ColumnHeader item6;
        private System.Windows.Forms.ColumnHeader item7;
        private System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader cancelled;
    }
}