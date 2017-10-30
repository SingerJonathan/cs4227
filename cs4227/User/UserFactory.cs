using System;

namespace cs4227.User
{
    class UserFactory
    {
        public AbstractUser GetUser(int id, string username, string firstName, string lastName, string password, string email, string userType,
            int restaurantId = 0, bool restaurantAdmin = false, bool systemAdmin = false, bool deleted = false)
        {
            if (userType == null)
                return null;

            LoginAPI loginAPI = new RegularUser();
            if (userType.Equals("SysAdmin"))
                loginAPI = new SysAdmin();
            else if (userType.Equals("RestAdmin"))
                loginAPI = new RestAdmin();

            return new User(id, username, firstName, lastName, password, email, loginAPI, restaurantId, restaurantAdmin, systemAdmin, deleted);
        }
    }
}
