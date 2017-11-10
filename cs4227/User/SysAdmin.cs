using System;
using cs4227.UI;

namespace cs4227.User
{
    public class SysAdmin : LoginAPI
    {
        private int UserId;

        public void login(string username, string password)
        {
            Console.WriteLine(@"System Admin " + username + @" logged in.");
            var systemAdmin = StaticAccessor.DB.GetUser(0, username);
            UserId = systemAdmin.Id;
            var SAM = new SysAdminMenu(UserId);
            SAM.ShowDialog();
        }
    }
}