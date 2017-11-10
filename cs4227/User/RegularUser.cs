using System;
using cs4227.UI;
using cs4227.Database;

namespace cs4227.User
{
    public class RegularUser : LoginAPI
    {
        private int UserId = 0;

        public void login(string username, string password)
        {
            Console.WriteLine(@"User " + username + @" logged in.");
            AbstractUser User = StaticAccessor.DB.GetUser(0, username);
            UserId = User.Id;
            UserMainMenu UM = new UserMainMenu(UserId);
            UM.ShowDialog();
        }
    }
}
