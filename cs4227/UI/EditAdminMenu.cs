using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using cs4227.User;

namespace cs4227.UI
{
    public partial class EditAdminMenu : Form
    {
        private string AdminEmail = "";
        private string AdminFirstName = "";
        private readonly int AdminId;
        private string AdminLastName = "";
        private string AdminPassword = "";
        private string AdminRestaurant = "";
        private string AdminUsername = "";
        private bool CorrectEmailFormat;
        private bool CorrectNameFormat;
        private bool CorrectPasswordFormat;
        private bool CorrectUsernameFormat;

        private string ErrorMessage = "";

        //private Boolean CorrectRestaurantFormat = false;
        private readonly bool newAdmin;

        private readonly int RestaurantId;
        private int ShowPassword = 1;
        private readonly bool sysAdmin;

        public EditAdminMenu(int AdminId, string AdminUsername, int RestaurantId, bool sysAdmin, bool newAdmin)
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
                Text = "SysAdmin Menu: Edit Admin";
                DeleteAdminButton.Show();
                DeleteAdminButton.Enabled = true;
                AdminPasswordTextbox.Visible = false;
                AdminPasswordTextbox.Enabled = false;
                CorrectPasswordFormat = true;
                AdminPasswordLabel.Visible = false;
                ShowPasswordCheckBox.Visible = false;
                ShowPasswordCheckBox.Enabled = false;
            }
            if (!sysAdmin && !newAdmin)
            {
                Text = "RestAdmin Menu: Edit Admin";
                DeleteAdminButton.Hide();
                DeleteAdminButton.Enabled = false;
            }

            if (!newAdmin)
            {
                var Admin = StaticAccessor.DB.GetUser(0, AdminUsername);
                var Rest = StaticAccessor.DB.GetRestaurant(Admin.RestaurantId);
                AdminEmail = Admin.Email;
                AdminFirstName = Admin.FirstName;
                AdminLastName = Admin.LastName;
                AdminPassword = Admin.Password;
                if (Rest == null)
                    AdminRestaurant = "";
                else
                    AdminRestaurant = Rest.Name;
                AdminEmailTextbox.Text = AdminEmail;
                AdminFirstNameTextbox.Text = AdminFirstName;
                AdminLastNameTextbox.Text = AdminLastName;
                //AdminPasswordTextbox.Text = AdminPassword;
            }
        }

        private void AdminFirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminFirstName = AdminFirstNameTextbox.Text;

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
            AdminLastName = AdminLastNameTextbox.Text;

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
            AdminEmail = AdminEmailTextbox.Text;

            if (AdminEmail.Length > 0)
            {
                try
                {
                    var m = new MailAddress(AdminEmail);
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
                //Add code to check if email already exists
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    AdminEmailLabel.Text = "Email:";
                    CorrectEmailFormat = true;
            }
        }

        private void AdminUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            var UsernameExists = false;
            if (newAdmin)
                AdminUsername = AdminUsernameTextbox.Text;
            else
                AdminUsernameTextbox.Text = AdminUsername;

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

                var Admin = StaticAccessor.DB.GetUser(0, AdminUsername);

                if (Admin.Username == null){}
                else
                    UsernameExists = true;


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
            AdminPassword = AdminPasswordTextbox.Text;

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
            if (CorrectEmailFormat && CorrectNameFormat && CorrectUsernameFormat &&
                CorrectPasswordFormat /* && CorrectRestaurantFormat*/)
            {
                var UsernameExists = false;
                var EmailExists = false;
                //Boolean RestaurantExists = false;
                var Admin = StaticAccessor.DB.GetUser(0, AdminUsername);
                var Admin2 = StaticAccessor.DB.GetUser(0, "", AdminEmail);
                //Restaurant.Restaurant Rest = DatabaseHandler.GetRestaurant(AdminRestaurant);

                if (newAdmin)
                {
                    if (Admin.Username == null){}
                    else
                    {
                        UsernameExists = true;
                        ErrorMessage = "Error: Username Already Exists.";
                    }
                    if (Admin2.Username == null){}
                    else
                    {
                        EmailExists = true;
                        ErrorMessage = "Error: Email Already Exists.";
                    }
                }

                if (!UsernameExists && !EmailExists)
                {
                    //check if admin already exists
                    var RestaurantAdminExists = StaticAccessor.DB.GetUser(0, "", "", 0, AdminRestaurant);
                    //AbstractUser IsCurrentAdmin = DatabaseHandler.CheckIfAdmin(AdminUsername);
                    var CurrentAdmin = StaticAccessor.DB.GetUser(0, AdminUsername);

                    //Hash password input so the raw password isn't stored in the database
                    string hashPassword;
                    if (sysAdmin && !newAdmin)
                        hashPassword = StaticAccessor.DB.GetUser(CurrentAdmin.Id).Password;
                    else
                        hashPassword = StaticAccessor.HashString(AdminPassword);

                    if (RestaurantAdminExists.Username == null)
                    {
                        if (newAdmin)
                        {
                            var restaurantId = StaticAccessor.DB.GetRestaurant(0, AdminRestaurant).Id;
                            var user = new UserFactory().GetUser(CurrentAdmin.Id, AdminUsername, hashPassword,
                                AdminFirstName, AdminLastName, AdminEmail, 0, "RestAdmin", restaurantId, true);
                            StaticAccessor.DB.InsertUser(user);
                            MessageBox.Show("New Admin Created");

                            Hide();
                            var SAAM = new SysAdminAdminsMenu(AdminId);
                            SAAM.ShowDialog();
                        }
                    }
                    else
                    {
                        if (CurrentAdmin.RestaurantAdmin) //admin of that restaurant
                        {
                            var restaurantId = StaticAccessor.DB.GetRestaurant(0, AdminRestaurant).Id;
                            var user = new UserFactory().GetUser(CurrentAdmin.Id, AdminUsername, hashPassword,
                                AdminFirstName, AdminLastName, AdminEmail, 0, "RestAdmin", restaurantId, true);
                            StaticAccessor.DB.UpdateUser(user);
                            MessageBox.Show("Admin Details Updated");

                            if (sysAdmin)
                            {
                                Hide();
                                var SAAM = new SysAdminAdminsMenu(AdminId);
                                SAAM.ShowDialog();
                            }
                            else
                            {
                                Hide();
                                var RAM = new RestAdminMainMenu(AdminId, RestaurantId);
                                RAM.ShowDialog();
                            }
                            MessageBox.Show("Admin Details Updated");

                            if (sysAdmin)
                            {
                                Hide();
                                var SAAM = new SysAdminAdminsMenu(AdminId);
                                SAAM.ShowDialog();
                            }
                            else
                            {
                                Hide();
                                var RAM = new RestAdminMainMenu(AdminId, RestaurantId);
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
                Hide();
                var SAAM = new SysAdminAdminsMenu(AdminId);
                SAAM.ShowDialog();
            }
            else
            {
                Hide();
                var RAM = new RestAdminMainMenu(AdminId, RestaurantId);
                RAM.ShowDialog();
            }
        }

        private void DeleteAdminButton_Click(object sender, EventArgs e)
        {
            if (sysAdmin)
            {
                var admin = StaticAccessor.DB.GetUser(0, AdminUsername);
                if (admin.RestaurantId <= 0)
                {
                    var dialogResult = MessageBox.Show("Are you sure you want to delete " + AdminUsername + "?",
                        "Delete Admin", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        admin.Deleted = true;
                        StaticAccessor.DB.UpdateUser(admin);

                        Hide();
                        var SAAM = new SysAdminAdminsMenu(AdminId);
                        SAAM.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                else
                {
                    MessageBox.Show(AdminUsername + " is currently an admin of " + AdminRestaurant +
                                    " and therefore cannot be deleted.\nChange the admin of that restaurant first.");
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