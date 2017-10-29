using System;
using cs4227.Menu;
using cs4227.Database;

namespace cs4227.User
{
    public class SysAdmin : LoginAPI
    {
        private int UserId = 0;

        public void login(string username, string password)
        {
            Console.WriteLine("System Admin " + username + " logged in.");
            AbstractUser systemAdmin = DatabaseHandler.GetUser(username);
            UserId = systemAdmin.Id;
            SysAdminMenu SAM = new SysAdminMenu(UserId);
            SAM.ShowDialog();
        }
    }
}
