using System;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class RestAdminMainMenu : Form
    {
        private readonly int AdminId;
        private string RestaurantAdmin = "";
        private readonly int RestaurantId;
        private string RestaurantName = "";

        public RestAdminMainMenu(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void RestMenu_Load(object sender, EventArgs e)
        {
            var Rest = StaticAccessor.DB.GetRestaurant(RestaurantId);
            var Admin = StaticAccessor.DB.GetUser(0, "", "", RestaurantId);
            RestaurantName = Rest.Name;
            RestaurantAdmin = Admin.Username;
            RestaurantNameLabel.Text = "Restaurant Name: " + RestaurantName;
            AdminUsernameLabel.Text = "Admin Username: " + RestaurantAdmin;
        }

        private void button1_Click(object sender, EventArgs e) //View Menu
        {
            Hide();
            var RAMI = new RestAdminViewMenu(AdminId, RestaurantId);
            RAMI.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //ChangeRestaurantDetails
        {
            Hide();
            var ERM = new EditRestaurantMenu(AdminId, RestaurantId, false, false);
            ERM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) //ManageOrder
        {
            Hide();
            var RAMO = new RestAdminManageOrders(AdminId, RestaurantId);
            RAMO.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginMenuV2();
        }

        private void EditAdminDetailsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var EAM = new EditAdminMenu(AdminId, RestaurantAdmin, RestaurantId, false, false);
            EAM.ShowDialog();
        }
    }
}