using System;
using cs4227.Menu;

namespace cs4227.User
{
    public class RestAdmin : LoginAPI
    {
        private string RestaurantName = "";

        public void login(string username, string password)
        {
            Console.WriteLine("Restaurant Admin " + username + " logged in.");
            RestMenu RM = new RestMenu(RestaurantName);
            RM.ShowDialog();
        }
    }
}
