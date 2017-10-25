using System;

namespace cs4227.User
{
    public abstract class AbstractUser
    {
        protected LoginAPI loginAPI;
        protected string username;
        protected string name;
        protected string password;

        public AbstractUser(string username, string name, string password, LoginAPI loginAPI)
        {
            this.loginAPI = loginAPI;
            this.username = username;
            this.name = name;
            this.password = password;
        }

        public abstract void login();
    }
}
