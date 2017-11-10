namespace cs4227.User
{
    internal class UserFactory
    {
        public AbstractUser GetUser(int id, string username, string password, string firstName, string lastName,
            string email, int membership,
            string userType, int restaurantId = 0, bool restaurantAdmin = false, bool systemAdmin = false,
            bool deleted = false)
        {
            if (userType == null)
                return null;

            LoginAPI loginAPI = new RegularUser();
            if (userType.Equals("SysAdmin"))
                loginAPI = new SysAdmin();
            else if (userType.Equals("RestAdmin"))
                loginAPI = new RestAdmin();

            return new User(id, username, password, firstName, lastName, email, membership, loginAPI, restaurantId,
                restaurantAdmin, systemAdmin, deleted);
        }
    }
}