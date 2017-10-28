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
    public partial class RestAdminMenu : Form
    {
        private int RestaurantId = 0;
        private string RestaurantName = "";
        private string RestaurantAdmin = "";

        public RestAdminMenu(int RestaurantId)
        {
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //View Menu
        {
            this.Hide();
            RestAdminMenuItem RAMI = new RestAdminMenuItem(RestaurantId);
            RAMI.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //ChangeRestaurantDetails
        {
            this.Hide();
            EditRestaurantMenu ERM = new EditRestaurantMenu(RestaurantId, false, false);
            ERM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //AddUsertoIgnoreList
        {
            this.Hide();
            RestAdminIgnoreListMenu RAILM = new RestAdminIgnoreListMenu(RestaurantId);
            RAILM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) //ManageOrder
        {
            this.Hide();
            RestAdminManageOrders RAMO = new RestAdminManageOrders(RestaurantId);
            RAMO.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu LM = new LoginMenu();
            LM.ShowDialog();
        }

        private void RestMenu_Load(object sender, EventArgs e)
        {
            RestaurantNameLabel.Text = "Restaurant Name: \n" + RestaurantName;
            AdminEmailLabel.Text = "Admin Email: \n" + RestaurantAdmin;
        }

        private void EditAdminDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAdminMenu EAM = new EditAdminMenu(RestaurantAdmin, RestaurantId, false, false);
            EAM.ShowDialog();
        }
    }
}
