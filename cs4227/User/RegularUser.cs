using System;
using cs4227.UI;

namespace cs4227.User
{
    public class RegularUser : LoginAPI
    {
        private int UserId;

        public void login(string username, string password)
        {
            Console.WriteLine(@"User " + username + @" logged in.");
            var User = StaticAccessor.DB.GetUser(0, username);
            UserId = User.Id;
            var UM = new UserMainMenu(UserId);
            UM.ShowDialog();
        }
    }
}