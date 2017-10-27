using System;
using cs4227.Menu;

namespace cs4227.User
{
    public class RegularUser : LoginAPI
    {
        private int UserId = 0;

        public void login(string username, string password)
        {
            Console.WriteLine("User " + username + " logged in.");
            //add code to get userid

            UserMainMenu UM = new UserMainMenu(UserId);
            UM.ShowDialog();
        }
    }
}
