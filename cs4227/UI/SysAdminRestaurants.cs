using System;
using System.Linq;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class SysAdminRestaurantsMenu : Form
    {
        private bool CorrectNameFormat;
        private string ErrorMessage = "";
        private int RestaurantId;
        private string RestaurantName = "";
        private readonly int UserId;

        public SysAdminRestaurantsMenu(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void ListOfRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantName = ListOfRestaurants.SelectedItems[0].Text;
            RestaurantId = int.Parse(ListOfRestaurants.SelectedItems[0].SubItems[1].Text);
            Hide();
            var SVR = new SysViewRestaraunt(UserId, RestaurantId);
            SVR.ShowDialog();
        }

        private void RestaurantNameTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantName = RestaurantNameTextbox.Text;

            if (RestaurantName.Length > 0)
            {
                if (RestaurantName.Any(char.IsSymbol))
                {
                    ErrorMessage = "Can't use Symbols\n in a Restaurant's Name";
                    CorrectNameFormat = false;
                }
                else
                {
                    CorrectNameFormat = true;
                }
            }
            else
            {
                CorrectNameFormat = false;
                ErrorMessage = "Can't have a blank Restaurant Name. \nTry Again!";
            }

            if (!CorrectNameFormat)
            {
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantNameLabel.Text = @"Enter Restaurant Name: ERROR";
            }
            else
            {
                    RestaurantNameLabel.Text = @"Enter Restaurant Name:";
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    CorrectNameFormat = true;
            }
        }

        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            if (CorrectNameFormat)
            {
                //add code to add correct Restaurantid ---list.length()+1 etc...

                Hide();
                var ERM = new EditRestaurantMenu(UserId, RestaurantId, true, true, RestaurantNameTextbox.Text);
                ERM.ShowDialog();
            }
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            var SAM = new SysAdminMenu(UserId);
            SAM.ShowDialog();
        }

        private void SysAdminRestaurantsMenu_Load(object sender, EventArgs e)
        {
            var restaurants = StaticAccessor.DB.GetRestaurants();
            foreach (var restaurant in restaurants)
            {
                var restaurantItem = new ListViewItem(restaurant.Name);
                restaurantItem.SubItems.Add(new ListViewItem.ListViewSubItem(restaurantItem, "" + restaurant.Id));
                ListOfRestaurants.Items.Add(restaurantItem);
            }
        }
    }
}