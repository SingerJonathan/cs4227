using System;
using cs4227.Menu;

namespace cs4227.User
{
    public class RegularUser : LoginAPI
    {
        public void login(string username, string password)
        {
            Console.WriteLine("User " + username + " logged in.");
            UserMainMenu UM = new UserMainMenu();
            UM.ShowDialog();
        }
    }
}
