using System;

namespace cs4227.User
{
    public abstract class AbstractUser
    {
        protected LoginAPI loginAPI;
        protected int id;
        protected string username;
        protected string firstName;
        protected string lastName;
        protected string password;
        protected string email;
        protected int restaurantAdmin;
        protected bool systemAdmin;
        protected bool deleted;

        public AbstractUser(int id, string username, string firstName, string lastName, string password, string email, LoginAPI loginAPI,
            int restaurantAdmin = 0, bool systemAdmin = false, bool deleted = false)
        {
            this.id = id;
            this.loginAPI = loginAPI;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
            this.restaurantAdmin = restaurantAdmin;
            this.systemAdmin = systemAdmin;
            this.deleted = deleted;
        }

        public abstract void login();
    }
}
