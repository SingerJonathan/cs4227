using System;

namespace cs4227.User
{
    public class User : AbstractUser
    {
        public User(int id, string username, string firstName, string lastName, string password, string email, LoginAPI loginAPI, int restaurantAdmin = 0, bool systemAdmin = false, bool deleted = false)
            : base(id, username, firstName, lastName, password, email, loginAPI, restaurantAdmin, systemAdmin, deleted)
        {
        }

        public override void login()
        {
            loginAPI.login(username, password);
        }
    }
}
