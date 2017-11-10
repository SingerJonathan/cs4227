namespace cs4227.User
{
    public abstract class AbstractUser
    {
        protected bool deleted;
        protected string email;
        protected string firstName;
        protected int id;
        protected string lastName;
        protected LoginAPI loginAPI;
        protected int membership;
        protected string password;
        protected bool restaurantAdmin;
        protected int restaurantId;
        protected bool systemAdmin;
        protected string username;

        public AbstractUser()
        {
        }

        public AbstractUser(int id, string username, string password, string firstName, string lastName, string email,
            int membership,
            LoginAPI loginAPI, int restaurantId = 0, bool restaurantAdmin = false, bool systemAdmin = false,
            bool deleted = false)
        {
            this.id = id;
            this.loginAPI = loginAPI;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
            this.membership = membership;
            this.restaurantId = restaurantId;
            this.restaurantAdmin = restaurantAdmin;
            this.systemAdmin = systemAdmin;
            this.deleted = deleted;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public int Membership
        {
            get => membership;
            set => membership = value;
        }

        public LoginAPI LoginAPI
        {
            get => loginAPI;
            set => loginAPI = value;
        }

        public int RestaurantId
        {
            get => restaurantId;
            set => restaurantId = value;
        }

        public bool RestaurantAdmin
        {
            get => restaurantAdmin;
            set => restaurantAdmin = value;
        }

        public bool SystemAdmin
        {
            get => systemAdmin;
            set => systemAdmin = value;
        }

        public bool Deleted
        {
            get => deleted;
            set => deleted = value;
        }

        public abstract void login();
    }
}