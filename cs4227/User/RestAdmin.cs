using System;
using cs4227.Menu;

namespace cs4227.User
{
    public class RestAdmin : LoginAPI
    {
        private int RestaurantId = 0;

        public void login(string username, string password)
        {
            Console.WriteLine("Restaurant Admin " + username + " logged in.");
            //add code to get restaurantid
            RestAdminMenu RM = new RestAdminMenu(RestaurantId);
            RM.ShowDialog();
        }
    }
}
