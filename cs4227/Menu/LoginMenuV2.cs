using System;
using System.Windows.Forms;
using cs4227.Database;
using cs4227.User;

namespace cs4227.Menu
{
    public partial class LoginMenuV2 : Form
    {
        Timer t = new Timer();
        private Boolean systemAdmin = false;
        private Boolean restaurantAdmin = false;
        private Boolean normalUser = false;
        private Boolean UserFound = false;
        private string Username = "";
        private string Password = "";

        public LoginMenuV2()
        {
            InitializeComponent();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.UpdateTime_Tick);

            t.Start();

            ErrorMessageLabel.Visible = false;
        }

        private void UpdateTime_Tick(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString("dd/MM/yyyy");
            String time = DateTime.Now.ToString("h:mm:ss tt");
            DisplayDateLabel.Text = "Date: " + date;
            DisplayTimeLabel.Text = "Current Time: " + time;
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            Username = UsernameTextbox.Text.ToString();
        }

        private void PaaswordTextbox_TextChanged(object sender, EventArgs e)
        {
            Password = PaaswordTextbox.Text.ToString();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Check User is exists in db

            if (UserFound)
            {
                if (systemAdmin)
                {
                    this.Hide();
                    // HARD CODED VALUES, REPLACE WHEN LOGIN IS IMPLEMENTED
                    //AbstractUser sysAdmin = new UserFactory().getUser(1, "geoffsysman96", "Geoff", "Sysman", "#Badpassword1", "geoffsysman96@gmail.com", "SysAdmin", 0, true);
                    AbstractUser sysAdmin = DatabaseHandler.GetUser(1);
                    sysAdmin.login();
                }

                if (restaurantAdmin)
                {
                    this.Hide();
                    // HARD CODED VALUES, REPLACE WHEN LOGIN IS IMPLEMENTED
                    //AbstractUser restAdmin = new UserFactory().getUser(8, "larryrestman96", "Larry", "Restman", "#Badpassword1", "larryrestman96@gmail.com", "RestAdmin", 1);
                    AbstractUser restAdmin = DatabaseHandler.GetUser(8);
                    restAdmin.login();
                }

                if (normalUser)
                {
                    this.Hide();
                    // HARD CODED VALUES, REPLACE WHEN LOGIN IS IMPLEMENTED
                    //AbstractUser user = new UserFactory().getUser(9, "michaeluserman96", "Michael", "Userman", "#Badpassword1", "michaeluserman96@gmail.com", "User");
                    AbstractUser user = DatabaseHandler.GetUser(9);
                    user.login();
                }
            }
            else
            {
                ErrorMessageLabel.Text = "Error Message: Incorrect Username or Password";
                ErrorMessageLabel.Visible = true;
            }
        }

        /*public static void Main()
        {
            LoginMenuV2 LG = new LoginMenuV2();
            LG.ShowDialog();
        } */
    }
}
