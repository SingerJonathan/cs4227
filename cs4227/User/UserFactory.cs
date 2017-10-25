using System;

namespace cs4227.User
{
    class UserFactory
    {
        public AbstractUser getUser(int id, string username, string firstName, string lastName, string password, string email, string userType,
            int restaurantAdmin = 0, bool systemAdmin = false, bool deleted = false)
        {
            if (userType == null)
                return null;

            LoginAPI loginAPI = new RegularUser();
            if (userType.Equals("SysAdmin"))
                loginAPI = new SysAdmin();
            else if (userType.Equals("RestAdmin"))
                loginAPI = new RestAdmin();

            return new User(id, username, firstName, lastName, password, email, loginAPI, restaurantAdmin, systemAdmin, deleted);
        }
    }
}
