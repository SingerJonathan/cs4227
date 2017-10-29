using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs4227.Menu
{
    public partial class RestAdminViewOrders : Form
    {
        private int AdminId = 0;
        private int RestaurantId = 0;
        private int OrderNo = 0;
        private string Username = "";
        private string Item00 = "";
        private string Item01 = "";
        private string Item02 = "";
        private string Item03 = "";
        private string Item04 = "";
        private string Item05 = "";
        private string Item06 = "";
        private string Item07 = "";
        private string Item08 = "";
        private string Item09 = "";
        private double Cost = 0.0;
        private string DeliveryAddress = "";
        private Boolean IsCancelled = false;
        


        public RestAdminViewOrders(int AdminId, int RestaurantId, int OrderNo)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            this.OrderNo = OrderNo;
            InitializeComponent();
        }

        private void RestAdminViewOrders_Load(object sender, EventArgs e)
        {
            OrderNumberLabel.Text = "Viewing Order No: " + OrderNo;

            //Add code to display order

            ListViewItem row = Order.Items[0];
            row.SubItems[0].Text = OrderNo.ToString();
            row.SubItems[1].Text = Username;
            row.SubItems[2].Text = Item00;
            row.SubItems[3].Text = Item01;
            row.SubItems[4].Text = Item02;
            row.SubItems[5].Text = Item03;
            row.SubItems[6].Text = Item04;
            row.SubItems[7].Text = Item05;
            row.SubItems[8].Text = Item06;
            row.SubItems[9].Text = Item07;
            row.SubItems[10].Text = Item08;
            row.SubItems[11].Text = Item09;
            row.SubItems[12].Text = Cost.ToString();
            row.SubItems[13].Text = DeliveryAddress;
            row.SubItems[14].Text = IsCancelled.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestAdminManageOrders RAMO = new RestAdminManageOrders(AdminId, RestaurantId);
            RAMO.ShowDialog();
        }
    }
}
