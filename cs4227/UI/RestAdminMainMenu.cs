using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cs4227.Database;
using cs4227.User;

namespace cs4227.UI
{
    public partial class RestAdminMainMenu : Form
    {
        private int RestaurantId = 0;
        private int AdminId = 0;
        private string RestaurantName = "";
        private string RestaurantAdmin = "";

        public RestAdminMainMenu(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void RestMenu_Load(object sender, EventArgs e)
        {
            Restaurant.Restaurant Rest = DatabaseHandler.GetRestaurant(RestaurantId);
            AbstractUser Admin = DatabaseHandler.GetAdmin(RestaurantId);
            RestaurantName = Rest.Name;
            RestaurantAdmin = Admin.Username;
            RestaurantNameLabel.Text = "Restaurant Name: " + RestaurantName;
            AdminUsernameLabel.Text = "Admin Username: " + RestaurantAdmin;
        }

        private void button1_Click(object sender, EventArgs e) //View Menu
        {
            this.Hide();
            RestAdminViewMenu RAMI = new RestAdminViewMenu(AdminId, RestaurantId);
            RAMI.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //ChangeRestaurantDetails
        {
            this.Hide();
            EditRestaurantMenu ERM = new EditRestaurantMenu(AdminId, RestaurantId, false, false);
            ERM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) //ManageOrder
        {
            this.Hide();
            RestAdminManageOrders RAMO = new RestAdminManageOrders(AdminId, RestaurantId);
            RAMO.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenuV2 LM = new LoginMenuV2();
            LM.ShowDialog();
        }

        private void EditAdminDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAdminMenu EAM = new EditAdminMenu(AdminId, RestaurantAdmin, RestaurantId, false, false);
            EAM.ShowDialog();
        }
    }
}
