using System;
using cs4227.Menu;

namespace cs4227.User
{
    public class RestAdmin : LoginAPI
    {
        public void login(string username, string password)
        {
            Console.WriteLine("Restaurant Admin " + username + " logged in.");
            ResMenu RM = new ResMenu();
            RM.ShowDialog();
        }
    }
}
