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

namespace cs4227.Menu
{
    public partial class SysAdminAdminsMenu : Form
    {
        private string AdminUsername = "";
        private int RestaurantId = 0;
        private int UserId = 0;
        private string ErrorMessage = "";
        private Boolean CorrectNameFormat = false;

        public SysAdminAdminsMenu(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void AdminsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminUsername = AdminsList.SelectedItems[0].Text.ToString();
            RestaurantId = Int32.Parse(AdminsList.SelectedItems[0].SubItems[2].Text);
            this.Hide();
            EditAdminMenu EAM = new EditAdminMenu(UserId, AdminUsername, RestaurantId, true, false);
            EAM.ShowDialog();
        }

        private void AdminUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminUsername = AdminUsernameTextbox.Text.ToString();

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
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminUsernameLabel.Text = "Username: ERROR";
            }
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            if (CorrectNameFormat)
            {
                Boolean UsernameExists = false;
                AbstractUser Admin = DatabaseHandler.GetUser(AdminUsername);

                if (Admin.Username == null)
                {
                    UsernameExists = false;
                }
                else
                {
                    UsernameExists = true;
                }


                if (!UsernameExists)
                {
                    AdminUsernameLabel.Text = "Username:";
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    this.Hide();
                    EditAdminMenu EAM = new EditAdminMenu(UserId, AdminUsername, RestaurantId, true, true);
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
            this.Hide();
            SysAdminMenu SAM = new SysAdminMenu(UserId);
            SAM.ShowDialog();
        }

        private void SysAdminAdminsMenu_Load(object sender, EventArgs e)
        {
            ErrorMessageLabel.Visible = false;
            List<AbstractUser> Admins = DatabaseHandler.GetAdmins();
            foreach (AbstractUser Admin in Admins)
            {
                ListViewItem AdminItem = new ListViewItem(Admin.Username);
                Restaurant.Restaurant Rest = DatabaseHandler.GetRestaurant(Admin.RestaurantId);
                AdminItem.SubItems.Add(new ListViewItem.ListViewSubItem(AdminItem, "" + Rest.Name));
                AdminItem.SubItems.Add(new ListViewItem.ListViewSubItem(AdminItem, "" + Admin.Id));
                AdminsList.Items.Add(AdminItem);
            }
        }
    }
}
