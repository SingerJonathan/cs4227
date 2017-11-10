using System;
using cs4227.UI;
using cs4227.Database;
using cs4227.Restaurant;
using cs4227.User;

namespace cs4227.User
{
    public class RestAdmin : LoginAPI
    {
        private int RestaurantId = 0;
        private int UserId = 0;

        public void login(string username, string password)
        {
            Console.WriteLine(@"Restaurant Admin " + username + @" logged in.");
            AbstractUser RestAdmin = StaticAccessor.DB.GetUser(0, username);
            RestaurantId = RestAdmin.RestaurantId;
            Restaurant.Restaurant Rest = StaticAccessor.DB.GetRestaurant(RestaurantId);

            RestAdminMainMenu RM = new RestAdminMainMenu(UserId, RestaurantId);
            RM.ShowDialog();
        }
    }
}
