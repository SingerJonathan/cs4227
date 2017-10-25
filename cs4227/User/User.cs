using System;

namespace cs4227.User
{
    public class User : AbstractUser
    {
        public User(string username, string name, string password, LoginAPI loginAPI) : base(username, name, password, loginAPI)
        {
        }

        public override void login()
        {
            loginAPI.login(username, password);
        }
    }
}
