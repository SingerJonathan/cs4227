namespace cs4227.User
{
    public class User : AbstractUser
    {
        public User()
        {
        }

        public User(int id, string username, string password, string firstName, string lastName, string email,
            int membership, LoginAPI loginAPI, int restaurantId = 0, bool restaurantAdmin = false,
            bool systemAdmin = false, bool deleted = false)
            : base(id, username, password, firstName, lastName, email, membership, loginAPI, restaurantId,
                restaurantAdmin, systemAdmin, deleted)
        {
        }

        public override void login()
        {
            loginAPI.login(username, password);
        }
    }
}