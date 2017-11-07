using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using cs4227.Database;
using cs4227.User;
using cs4227.Restaurant;

namespace cs4227.UI
{
    public partial class EditAdminMenu : Form
    {
        private int RestaurantId = 0;
        private int AdminId = 0;
        private string AdminEmail = "";
        private string AdminFirstName = "";
        private string AdminLastName = "";
        private string AdminUsername = "";
        private string AdminPassword = "";
        private string AdminRestaurant = "";
        private string ErrorMessage = "";
        private Boolean CorrectEmailFormat = false;
        private Boolean CorrectNameFormat = false;
        private Boolean CorrectUsernameFormat = false;
        private Boolean CorrectPasswordFormat = false;
        //private Boolean CorrectRestaurantFormat = false;
        private Boolean newAdmin = false;
        private Boolean sysAdmin = false;
        private int ShowPassword = 1;

        public EditAdminMenu(int AdminId, string AdminUsername, int RestaurantId, Boolean sysAdmin, Boolean newAdmin)
        {
            this.AdminId = AdminId;
            this.AdminUsername = AdminUsername;
            this.RestaurantId = RestaurantId; 
            this.sysAdmin = sysAdmin;
            this.newAdmin = newAdmin;
            InitializeComponent();
        }

        private void EditAdminMenu_Load(object sender, EventArgs e)
        {
            AdminUsernameTextbox.Text = AdminUsername;
            CorrectUsernameFormat = true;
            ErrorMessageLabel.Visible = false;
            if (sysAdmin && !newAdmin)
            {
                this.Text = "SysAdmin Menu: Edit Admin";
                DeleteAdminButton.Show();
                DeleteAdminButton.Enabled = true;
            }
            if(!sysAdmin && !newAdmin)
            {
                this.Text = "RestAdmin Menu: Edit Admin";
                DeleteAdminButton.Hide();
                DeleteAdminButton.Enabled = false;
            }

            if (!newAdmin)
            {
                AbstractUser Admin = DatabaseHandler.GetUser(AdminUsername);
                Restaurant.Restaurant Rest = DatabaseHandler.GetRestaurant(Admin.RestaurantId);
                AdminEmail = Admin.Email;
                AdminFirstName = Admin.FirstName;
                AdminLastName = Admin.LastName;
                AdminPassword = Admin.Password;
                if (Rest == null)
                {
                    AdminRestaurant = "";
                }
                else
                {
                    AdminRestaurant = Rest.Name;
                }
                AdminEmailTextbox.Text = AdminEmail;
                AdminFirstNameTextbox.Text = AdminFirstName;
                AdminLastNameTextbox.Text = AdminLastName;
                //AdminPasswordTextbox.Text = AdminPassword;
            }
        }

        private void AdminFirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminFirstName = AdminFirstNameTextbox.Text.ToString();

            if (AdminFirstName.Length > 0)
            {
                CorrectNameFormat = true;
                if (AdminFirstName.Any(char.IsDigit))
                {
                    ErrorMessage = "Can't Use Numbers in a Name";
                    CorrectNameFormat = false;
                }

                if (AdminFirstName.Any(char.IsSymbol) || AdminFirstName.Any(char.IsPunctuation))
                {
                    ErrorMessage = "Can't Use Symbols in a Name";
                    CorrectNameFormat = false;
                }
            }
            else
            {
                CorrectNameFormat = false;
                ErrorMessage = "Can't have a blank Name. Try Again!";
            }

            if (!CorrectNameFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminFirstNameLabel.Text = "First Name: ERROR";
            }
            else
            {
                AdminFirstNameLabel.Text = "First Name:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void AdminLastNameTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminLastName = AdminLastNameTextbox.Text.ToString();

            if (AdminLastName.Length > 0)
            {
                CorrectNameFormat = true;
                if (AdminLastName.Any(char.IsDigit))
                {
                    ErrorMessage = "Can't Use Numbers in a Name";
                    CorrectNameFormat = false;
                }

                if (AdminLastName.Any(char.IsSymbol) || AdminLastName.Any(char.IsPunctuation))
                {
                    ErrorMessage = "Can't Use Symbols in a Name";
                    CorrectNameFormat = false;
                }
            }
            else
            {
                CorrectNameFormat = false;
                ErrorMessage = "Can't have a blank Name. Try Again!";
            }

            if (!CorrectNameFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminLastNameLabel.Text = "Last Name: ERROR";
            }
            else
            {
                AdminLastNameLabel.Text = "Last Name:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void AdminEmailTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminEmail = AdminEmailTextbox.Text.ToString();

            if (AdminEmail.Length > 0)
            {
                try
                {
                    MailAddress m = new MailAddress(AdminEmail);
                    CorrectEmailFormat = true;
                }
                catch (FormatException)
                {

                }
                if (!CorrectEmailFormat)
                {
                    ErrorMessage = "Incorrect Email Format. Try Again!";
                    CorrectEmailFormat = false;
                }
            }
            else
            {
                CorrectEmailFormat = false;
                ErrorMessage = "Can't have a blank Email. Try again!";
            }

            if (!CorrectEmailFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminEmailLabel.Text = "Email: ERROR";
            }
            else
            {
                Boolean EmailExists = false;
                //Add code to check if email already exists

                if (!EmailExists)
                {
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    AdminEmailLabel.Text = "Email:";
                    CorrectEmailFormat = true;
                }
                else
                {
                    ErrorMessageLabel.Text = "Error Message: Email already exists. Try Again!";
                    ErrorMessageLabel.Visible = true;
                    AdminEmailLabel.Text = "Email: ERROR";
                    CorrectEmailFormat = false;
                }
            }
        }

        private void AdminUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (newAdmin)
            {
                AdminUsername = AdminUsernameTextbox.Text.ToString();
            }
            else
            {
                AdminUsernameTextbox.Text = AdminUsername;
            }

            if (AdminUsername.Length > 0)
            {
                if (AdminUsername.Any(char.IsPunctuation) || AdminUsername.Any(char.IsWhiteSpace))
                {
                    CorrectUsernameFormat = false;
                    ErrorMessage = "Can't Use Spaces or Punctuation for a Username";
                }
                else
                {
                    CorrectUsernameFormat = true;
                }
            }
            else
            {
                CorrectUsernameFormat = false;
                ErrorMessage = "Can't have a blank Username. Try Again!";
            }

            if (!CorrectUsernameFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminUsernameLabel.Text = "Username: ERROR";
            }
            else
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
                }
                else if (newAdmin)
                {
                    ErrorMessageLabel.Text = "Error Message: Username already exists. Try Again!";
                    ErrorMessageLabel.Visible = true;
                    AdminUsernameLabel.Text = "Username: ERROR";
                    CorrectNameFormat = false;
                }
            }
        }

        private void AdminPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminPassword = AdminPasswordTextbox.Text.ToString();

            if (AdminPassword.Length > 4)
            {
                if (!AdminPassword.Any(char.IsUpper))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain an Upper Case letter";
                }
                else if (!AdminPassword.Any(char.IsLower))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain a Lower Case letter";
                }
                else if (!AdminPassword.Any(char.IsDigit))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain a Number";
                }
                else if (!AdminPassword.Any(char.IsSymbol) && !AdminPassword.Any(char.IsPunctuation))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain a Symbol";
                }
                else
                {
                    CorrectPasswordFormat = true;
                }
            }
            else
            {
                CorrectPasswordFormat = false;
                ErrorMessage = "Passwords Must be Longer than 4 characters. Try Again!";
            }

            if (!CorrectPasswordFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminPasswordLabel.Text = "Password: ERROR";
            }
            else
            {
                AdminPasswordLabel.Text = "Password:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (CorrectEmailFormat && CorrectNameFormat && CorrectUsernameFormat && CorrectPasswordFormat/* && CorrectRestaurantFormat*/)
            {
                Boolean UsernameExists = false;
                Boolean EmailExists = false;
                //Boolean RestaurantExists = false;
                AbstractUser Admin = DatabaseHandler.GetUser(AdminUsername);
                AbstractUser Admin2 = DatabaseHandler.GetUserEmail(AdminEmail);
                //Restaurant.Restaurant Rest = DatabaseHandler.GetRestaurant(AdminRestaurant);

                if (newAdmin)
                {
                    if (Admin.Username == null)
                    {
                        UsernameExists = false;
                    }
                    else
                    {
                        UsernameExists = true;
                        ErrorMessage = "Error: Username Already Exists.";
                    }
                    if (Admin2.Username == null)
                    {
                        EmailExists = false;
                    }
                    else
                    {
                        EmailExists = true;
                        ErrorMessage = "Error: Email Already Exists.";
                    }
                }
                /*if (Rest == null)
                {
                    RestaurantExists = false;
                    ErrorMessage = "Restaurant Doesn't Exist";
                }
                else
                {
                    RestaurantExists = true;
                }*/

                if (!UsernameExists && !EmailExists/* && RestaurantExists*/)
                {
                    //check if admin already exists
                    AbstractUser RestaurantAdminExists = DatabaseHandler.CheckAdminExists(AdminRestaurant);
                    AbstractUser IsCurrentAdmin = DatabaseHandler.CheckIfAdmin(AdminUsername);
                    
                    //Hash password input so the raw password isn't stored in the database
                    string hashPassword = StaticAccessor.HashString(AdminPassword);

                    if (RestaurantAdminExists.Username == null)
                    {
                        if (newAdmin)
                        {
                            int restaurantId = DatabaseHandler.GetRestaurant(AdminRestaurant).Id;
                            AbstractUser user = new UserFactory().GetUser(IsCurrentAdmin.Id, AdminUsername, hashPassword, AdminFirstName, AdminLastName, AdminEmail, 0, "RestAdmin", restaurantId, true);
                            DatabaseHandler.InsertUser(user);
                            MessageBox.Show("New Admin Created");

                            this.Hide();
                            SysAdminAdminsMenu SAAM = new SysAdminAdminsMenu(AdminId);
                            SAAM.ShowDialog();
                        }
                    }
                    else
                    {
                        if (IsCurrentAdmin.Username != null) //admin of that restaurant
                        {
                            int restaurantId = DatabaseHandler.GetRestaurant(AdminRestaurant).Id;
                            AbstractUser user = new UserFactory().GetUser(IsCurrentAdmin.Id, AdminUsername, hashPassword, AdminFirstName, AdminLastName, AdminEmail, 0, "RestAdmin", restaurantId, true);
                            DatabaseHandler.UpdateUser(user);
                            MessageBox.Show("Admin Details Updated");

                            if (sysAdmin)
                            {
                                this.Hide();
                                SysAdminAdminsMenu SAAM = new SysAdminAdminsMenu(AdminId);
                                SAAM.ShowDialog();
                            }
                            else
                            {
                                this.Hide();
                                RestAdminMainMenu RAM = new RestAdminMainMenu(AdminId, RestaurantId);
                                RAM.ShowDialog();
                            }
                            MessageBox.Show("Admin Details Updated");

                            if (sysAdmin)
                            {
                                this.Hide();
                                SysAdminAdminsMenu SAAM = new SysAdminAdminsMenu(AdminId);
                                SAAM.ShowDialog();
                            }
                            else
                            {
                                this.Hide();
                                RestAdminMainMenu RAM = new RestAdminMainMenu(AdminId, RestaurantId);
                                RAM.ShowDialog();
                            }
                        }
                        else
                        {
                            UsernameExists = true;
                            MessageBox.Show("Error: An Admin Already exists for that restaurant");
                        }
                    }
                }
                else
                {
                    ErrorMessageLabel.Visible = true;
                    ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                }
            }
            else
            {
                ErrorMessageLabel.Text = "Error Message: Please Fix Any Issues with the Admin's details";
                ErrorMessageLabel.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (sysAdmin)
            {
                this.Hide();
                SysAdminAdminsMenu SAAM = new SysAdminAdminsMenu(AdminId);
                SAAM.ShowDialog();
            }
            else
            {
                this.Hide();
                RestAdminMainMenu RAM = new RestAdminMainMenu(AdminId, RestaurantId);
                RAM.ShowDialog();
            }
        }

        private void DeleteAdminButton_Click(object sender, EventArgs e)
        {
            if(sysAdmin)
            {
                AbstractUser admin = DatabaseHandler.GetUser(AdminUsername);
                if (admin.RestaurantId <= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + AdminUsername + "?", "Delete Admin", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        admin.Deleted = true;
                        DatabaseHandler.UpdateUser(admin);

                        this.Hide();
                        SysAdminAdminsMenu SAAM = new SysAdminAdminsMenu(AdminId);
                        SAAM.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                else
                {
                    MessageBox.Show(AdminUsername + " is currently an admin of " + AdminRestaurant + " and therefore cannot be deleted.\nChange the admin of that restaurant first.");
                }
            }
        }

        private void AdminEmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminUsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword = ShowPassword * -1;
            if (ShowPassword == -1)
                AdminPasswordTextbox.PasswordChar = '\0';
            else
                AdminPasswordTextbox.PasswordChar = '*';
        }
    }
}
