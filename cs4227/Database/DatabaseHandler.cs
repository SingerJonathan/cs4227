using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using cs4227.Restaurant;
using cs4227.User;

namespace cs4227.Database
{
    class DatabaseHandler
    {
        private const string DB_NAME = "Database";
        
        public static SqlConnection GetLocalDBConnection()
        {
            try
            {
                string outputFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string dbFileName = Path.Combine(outputFolder, DB_NAME + ".mdf");
                string logFileName = Path.Combine(outputFolder, String.Format("{0}_log.ldf", DB_NAME));

                string connectionString = String.Format(@"Data Source=(LocalDB)\v11.0;AttachDBFileName={1};Initial Catalog={0};Integrated Security=True;", DB_NAME, dbFileName);
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch
            {
                throw;
            }
        }
        
        #region INSERT

        public static void InsertOrder(Order order)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO [dbo].[Orders] VALUES (" + order.UserId + ", ";
            for (int index = 0; index < 8; index++)
            {
                if (index < order.FoodItems.Count)
                    command.CommandText += order.FoodItems[index].Id + ", ";
                else
                    command.CommandText += "NULL, ";
            }
            command.CommandText += "0)";
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        public static void InsertRestaurant(Restaurant.Restaurant restaurant)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("INSERT INTO [dbo].[Restaurants] VALUES ({0}, '{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, {11})",
                restaurant.Id, restaurant.Name, restaurant.Address, restaurant.OwnerId, restaurant.Phone, restaurant.Email, restaurant.OpeningHours, restaurant.ClosingHours, restaurant.Days, restaurant.Type, restaurant.Delivery, restaurant.Deleted);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        public static void InsertFoodItem(FoodItem item)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO [dbo].[Items] VALUES (" + item.Id + ", '" + item.Name + "', " + item.Cost + ", " + item.RestaurantId + ", " + item.Deleted;
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        public static void InsertUser(AbstractUser user)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            string restaurantAdmin = "NULL";
            if (user.RestaurantAdmin != 0)
                restaurantAdmin = ""+user.RestaurantAdmin;
            command.CommandText = "INSERT INTO [dbo].[Users] VALUES (" + user.Id + ", '" + user.Username + "', '" + user.Password + "', '" + user.FirstName +
                "', '" + user.LastName + "', '" + user.Email + "', " + restaurantAdmin + ", " + user.SystemAdmin + ", " + user.Deleted;
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        #endregion
        #region UPDATE

        public static void UpdateOrder(Order order)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE [dbo].[Orders] SET [User] = "+order.UserId+", ";
            for (int index = 0; index < 8; index++)
            {
                if (index < order.FoodItems.Count)
                    command.CommandText += "[Item"+index+"] = "+order.FoodItems[index].Id + ", ";
                else
                    command.CommandText += "[Item" + index + "] = NULL, ";
            }
            command.CommandText += "[Cancelled] = "+(order.Cancelled ? 1 : 0)+", [Address] = "+order.Address+", [Cost] = "+order.Cost + " WHERE [Id] = " + order.Id;
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        public static void UpdateRestaurant(Restaurant.Restaurant restaurant)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("UPDATE [dbo].[Restaurants] SET [Name] = '{1}', [Address] = '{2}', [OwnerId] = {3}, [Phone] = '{4}', [Email] = '{5}', [OpeningHours] = '{6}', [ClosingHours] = '{7}', [Days] = '{8}', [Type] = '{9}', [Delivery] = {10}, [Deleted] = {11} WHERE [Id] = {0}",
                restaurant.Id, restaurant.Name, restaurant.Address, restaurant.OwnerId, restaurant.Phone, restaurant.Email, restaurant.OpeningHours, restaurant.ClosingHours, restaurant.Days, restaurant.Type, restaurant.Delivery, restaurant.Deleted);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        public static void UpdateFoodItem(FoodItem item)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE [dbo].[Items] SET [Name] = '" + item.Name + "', [Cost] = " + item.Cost +
                ", [Restaurant] = " + item.RestaurantId + ", [Deleted] = " + item.Deleted + " WHERE [Id] = " + item.Id;
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        public static void UpdateUser(AbstractUser user)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            string restaurantAdmin = "NULL";
            if (user.RestaurantAdmin != 0)
                restaurantAdmin = "" + user.RestaurantAdmin;
            command.CommandText = "UPDATE [dbo].[Users] SET [Username] = '" + user.Username + "', [Password] = '" + user.Password + "', [FirstName] = '" + user.FirstName +
                "', [LastName] = '" + user.LastName + "', [Email] = '" + user.Email + "', [RestaurantAdmin] = " +restaurantAdmin +
                ", [SystemAdmin] = " + user.SystemAdmin + ", [Deleted] = " + user.Deleted + " WHERE [Id] = " + user.Id;
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        #endregion
        #region SELECT / GET

        public static Order GetOrder(int id)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Orders] WHERE [Id] = " + id;
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            Order order = new Order();
            while (reader.Read())
            {
                order.Id = (int)reader["Id"];
                order.UserId = (int)reader["User"];
                order.Address = (string)reader["Address"];
                order.Cost = Convert.ToDouble(reader["Cost"]);
                order.Cancelled = (bool)reader["Cancelled"];
                order.Add(GetFoodItem((int)reader["Id"]));
            }
            connection.Close();
            return order;
        }

        public static Restaurant.Restaurant GetRestaurant(int id)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Restaurants] WHERE [Id] = " + id;
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            Restaurant.Restaurant restaurant = new Restaurant.Restaurant();
            if (reader.Read())
                restaurant = new Restaurant.Restaurant(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4),
                    reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), Convert.ToDouble(reader[10]), reader.GetBoolean(11));
            connection.Close();
            return restaurant;
        }

        public static FoodItem GetFoodItem(int id)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Items] WHERE [Id] = " + id;
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            FoodItem foodItem = new FoodItem();
            if (reader.Read())
                foodItem = new FoodItem(reader.GetInt32(0), reader.GetString(1), Convert.ToDouble(reader[2]), reader.GetInt32(3), reader.GetBoolean(4));
            connection.Close();
            return foodItem;
        }

        public static AbstractUser GetUser(int id)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Users] WHERE [Id] = " + id;
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            AbstractUser user = new User.User();
            if (reader.Read())
            {
                string userType = "User";
                if (reader.GetBoolean(7))
                    userType = "SysAdmin";
                else if (!reader.IsDBNull(6) && reader.GetInt32(6) > 0)
                    userType = "RestAdmin";
                int restaurantAdmin = 0;
                if (!reader.IsDBNull(6))
                    restaurantAdmin = reader.GetInt32(6);
                user = new UserFactory().GetUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetString(5), userType, restaurantAdmin, reader.GetBoolean(7), reader.GetBoolean(8));
            }
            connection.Close();
            return user;
        }

        public static int GetNewestOrderId()
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Max([Id]) FROM [dbo].[Orders]";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            int result = 0;
            if (reader.Read())
                result = reader.GetInt32(0);
            connection.Close();
            return result;
        }

        #endregion
        #region SELECT / GET ALL

        public static List<Order> GetOrders()
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Orders]";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            List<Order> orders = new List<Order>();
            while (reader.Read())
            {
                Order order = new Order();
                order.Id = (int)reader["Id"];
                order.UserId = (int)reader["User"];
                order.Address = (string)reader["Address"];
                order.Cost = Convert.ToDouble(reader["Cost"]);
                order.Cancelled = (bool)reader["Cancelled"];
                order.Add(GetFoodItem((int)reader["Id"]));
                orders.Add(order);
            }
            connection.Close();
            return orders;
        }

        public static List<Restaurant.Restaurant> GetRestaurants()
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Items]";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            List<Restaurant.Restaurant> restaurants = new List<Restaurant.Restaurant>();
            while (reader.Read())
            {
                Restaurant.Restaurant restaurant = new Restaurant.Restaurant(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4),
                    reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), Convert.ToDouble(reader[10]), reader.GetBoolean(11));
                restaurants.Add(restaurant);
            }
            connection.Close();
            return restaurants;
        }

        public static List<FoodItem> GetFoodItems()
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Items]";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            List<FoodItem> foodItems = new List<FoodItem>();
            while (reader.Read())
            {
                FoodItem foodItem = new FoodItem(reader.GetInt32(0), reader.GetString(1), Convert.ToDouble(reader[2]), reader.GetInt32(3), reader.GetBoolean(4));
                foodItems.Add(foodItem);
            }
            connection.Close();
            return foodItems;
        }

        public static List<AbstractUser> GetUsers()
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Users]";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            List<AbstractUser> users = new List<AbstractUser>();
            while (reader.Read())
            {
                AbstractUser user = new User.User();
                string userType = "User";
                if (reader.GetBoolean(7))
                    userType = "SysAdmin";
                else if (!reader.IsDBNull(6) && reader.GetInt32(6) > 0)
                    userType = "RestAdmin";
                int restaurantAdmin = 0;
                if (!reader.IsDBNull(6))
                    restaurantAdmin = reader.GetInt32(6);
                user = new UserFactory().GetUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetString(5), userType, restaurantAdmin, reader.GetBoolean(7), reader.GetBoolean(8));
                users.Add(user);
            }
            connection.Close();
            return users;
        }

        #endregion
    }
}
