using System;
using cs4227.UI;

namespace cs4227.User
{
    public class RestAdmin : LoginAPI
    {
        private int RestaurantId;
        private readonly int UserId = 0;

        public void login(string username, string password)
        {
            Console.WriteLine(@"Restaurant Admin " + username + @" logged in.");
            var RestAdmin = StaticAccessor.DB.GetUser(0, username);
            RestaurantId = RestAdmin.RestaurantId;

            var RM = new RestAdminMainMenu(UserId, RestaurantId);
            RM.ShowDialog();
        }
    }
}