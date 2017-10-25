using System;
using cs4227.Menu;

namespace cs4227.User
{
    public class SysAdmin : LoginAPI
    {
        public void login(string username, string password)
        {
            Console.WriteLine("System Admin " + username + " logged in.");
            SysAdminMenu SAM = new SysAdminMenu();
            SAM.ShowDialog();
        }
    }
}
