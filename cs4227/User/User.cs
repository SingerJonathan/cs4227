using System;

namespace cs4227.User
{
    public class User : AbstractUser
    {
        public User()
        {
        }

        public User(int id, string username, string firstName, string lastName, string password, string email, LoginAPI loginAPI, int restaurantId = 0, bool restaurantAdmin = false, bool systemAdmin = false, bool deleted = false)
            : base(id, username, firstName, lastName, password, email, loginAPI, restaurantId, restaurantAdmin, systemAdmin, deleted)
        {
        }

        public override void login()
        {
            loginAPI.login(username, password);
        }
    }
}
