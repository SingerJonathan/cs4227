using System;
using System.Linq;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class SysAdminAdminsMenu : Form
    {
        private string AdminUsername = "";
        private bool CorrectNameFormat;
        private string ErrorMessage = "";
        private int RestaurantId;
        private readonly int UserId;

        public SysAdminAdminsMenu(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void AdminsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminUsername = AdminsList.SelectedItems[0].Text;
            RestaurantId = int.Parse(AdminsList.SelectedItems[0].SubItems[2].Text);
            Hide();
            var EAM = new EditAdminMenu(UserId, AdminUsername, RestaurantId, true, false);
            EAM.ShowDialog();
        }

        private void AdminUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminUsername = AdminUsernameTextbox.Text;

            if (AdminUsername.Length > 0)
            {
                if (AdminUsername.Any(char.IsPunctuation) || AdminUsername.Any(char.IsWhiteSpace))
                {
                    CorrectNameFormat = false;
                    ErrorMessage = "Can't Use Spaces or Punctuation for an Username";
                }
                else
                {
                    CorrectNameFormat = true;
                }
            }
            else
            {
                CorrectNameFormat = false;
                ErrorMessage = "Can't have a blank Username. Try Again!";
            }

            if (!CorrectNameFormat)
            {
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminUsernameLabel.Text = @"Username: ERROR";
            }
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            if (CorrectNameFormat)
            {
                var UsernameExists = false;
                var Admin = StaticAccessor.DB.GetUser(0, AdminUsername);

                if (Admin.Username == null) {}
                else
                    UsernameExists = true;


                if (!UsernameExists)
                {
                    AdminUsernameLabel.Text = @"Username:";
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    Hide();
                    var EAM = new EditAdminMenu(UserId, AdminUsername, RestaurantId, true, true);
                    EAM.ShowDialog();
                }
                else
                {
                    ErrorMessageLabel.Text = "Error Message: Username already exists. \nTry Again!";
                    ErrorMessageLabel.Visible = true;
                    AdminUsernameLabel.Text = "Username: ERROR";
                    CorrectNameFormat = false;
                }
            }
            else
            {
                ErrorMessageLabel.Text = "Error Message: Please Fix Any Issues \nwith the Admin's Email";
                ErrorMessageLabel.Visible = true;
            }
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            var SAM = new SysAdminMenu(UserId);
            SAM.ShowDialog();
        }

        private void SysAdminAdminsMenu_Load(object sender, EventArgs e)
        {
            ErrorMessageLabel.Visible = false;
            var Admins = StaticAccessor.DB.GetUsers(true);
            foreach (var Admin in Admins)
            {
                var AdminItem = new ListViewItem(Admin.Username);
                var Rest = StaticAccessor.DB.GetRestaurant(Admin.RestaurantId);
                AdminItem.SubItems.Add(new ListViewItem.ListViewSubItem(AdminItem, "" + Rest.Name));
                AdminItem.SubItems.Add(new ListViewItem.ListViewSubItem(AdminItem, "" + Admin.Id));
                AdminsList.Items.Add(AdminItem);
            }
        }
    }
}