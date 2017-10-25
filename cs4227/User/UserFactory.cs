using System;

namespace cs4227.User
{
    class UserFactory
    {
        public AbstractUser getUser(string username, string name, string password, string userType)
        {
            if (userType == null)
                return null;
            if (userType.Equals("User"))
                return new User(username, name, password, new RegularUser());
            else if (userType.Equals("SysAdmin"))
                return new User(username, name, password, new SysAdmin());
            else if (userType.Equals("RestAdmin"))
                return new User(username, name, password, new RestAdmin());
            return null;
        }
    }
}
