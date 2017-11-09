using cs4227.Restaurant;
using cs4227.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace cs4227.Database
{
    class DatabaseHandler
    {
        private const string DB_NAME = "Database";
        
        public static SqlConnection GetLocalDBConnection()
        {
            string outputFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dbFileName = Path.Combine(outputFolder, $"{DB_NAME}.mdf");
            string logFileName = Path.Combine(outputFolder, $"{DB_NAME}_log.ldf");

            string connectionString = String.Format(@"Data Source=(LocalDB)\v11.0;AttachDBFileName={1};Initial Catalog={0};Integrated Security=True;", DB_NAME, dbFileName);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        
        #region INSERT

        public static void InsertOrder(Order order)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("INSERT INTO [dbo].[Orders] VALUES ({0}, {1}, ", order.UserId, order.RestaurantId);
            for (int index = 0; index < 8; index++)
            {
                if (index < order.FoodItems.Count)
                    command.CommandText += $"{order.FoodItems[index].Id}, ";
                else
                    command.CommandText += "NULL, ";
            }
            command.CommandText += String.Format("{0}, '{1}', {2})", order.Cost, order.Address, order.Cancelled?"1":"0");
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($"({result} row(s) affected)");
        }

        public static void InsertRestaurant(Restaurant.Restaurant restaurant)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            string restaurantName = restaurant.Name;
            if (restaurantName.Contains("'"))
                restaurantName = restaurantName.Replace("'", "''");
            command.CommandText = String.Format("INSERT INTO [dbo].[Restaurants] VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10})",
                                                restaurantName, restaurant.Address, restaurant.OwnerId, restaurant.Phone, restaurant.Email,restaurant.OpeningHours,
                                                restaurant.ClosingHours, restaurant.Days, restaurant.Type, restaurant.Delivery, restaurant.Deleted?"1":"0");
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($"({result} row(s) affected)");
        }

        public static void InsertFoodItem(FoodItem item)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("INSERT INTO [dbo].[Items] VALUES ('{0}', {1}, {2}, {3}, {4})",
                                                item.Name, item.Cost, item.RestaurantId, item.Discounts[1], item.Deleted?"1":"0");
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($"({result} row(s) affected)");
        }

        public static void InsertUser(AbstractUser user)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            string restaurantId = "NULL";
            if (user.RestaurantId != 0)
                restaurantId = ""+user.RestaurantId;
            command.CommandText = String.Format("INSERT INTO [dbo].[Users] VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, {8}, {9})",
                                                user.Username, user.Password, user.FirstName, user.LastName, user.Email, user.Membership,
                                                restaurantId, user.RestaurantAdmin?"1":"0",user.SystemAdmin?"1":"0", user.Deleted?"1":"0");
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($"({result} row(s) affected)");
        }

        #endregion
        #region UPDATE

        public static void UpdateOrder(Order order)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("UPDATE [dbo].[Orders] SET [User] = {0}, [Restaurant] = {1}, ", order.UserId, order.RestaurantId);
            for (int index = 0; index < 8; index++)
            {
                if (index < order.FoodItems.Count)
                    command.CommandText += $"[Item{index}] = {order.FoodItems[index].Id}, ";
                else
                    command.CommandText += $"[Item{index}] = NULL, ";
            }
            command.CommandText += String.Format("[Cancelled] = {0}, [Address] = '{1}', [Cost] = {2} WHERE [Id] = ",
                                                 order.Cancelled?1:0, order.Address, order.Cost);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($"({result} row(s) affected)");
        }

        public static void UpdateRestaurant(Restaurant.Restaurant restaurant)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            string restaurantName = restaurant.Name;
            if (restaurantName.Contains("'"))
                restaurantName = restaurantName.Replace("'", "''");
            command.CommandText = String.Format("UPDATE [dbo].[Restaurants] SET [Name] = '{1}', [Address] = '{2}', [OwnerId] = {3}, [Phone] = '{4}', [Email] = '{5}', " +
                                                "[OpeningHours] = '{6}', [ClosingHours] = '{7}', [Days] = '{8}', [Type] = '{9}', [Delivery] = {10}, [Deleted] = {11} WHERE [Id] = {0}",
                                                restaurant.Id, restaurantName, restaurant.Address, restaurant.OwnerId, restaurant.Phone, restaurant.Email, restaurant.OpeningHours,
                                                restaurant.ClosingHours, restaurant.Days, restaurant.Type, restaurant.Delivery, (restaurant.Deleted?"1":"0"));
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($"({result} row(s) affected)");
        }

        public static void UpdateFoodItem(FoodItem item)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("UPDATE [dbo].[Items] SET [Name] = '{0}', [Cost] = {1}, [Restaurant] = {2}, [BronzeDiscount] = {3}, [Deleted] = {4} WHERE [Id] = {5}",
                                                item.Name, item.Cost, item.RestaurantId, item.Discounts[1], item.Deleted?"1":"0", item.Id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($"({result} row(s) affected)");
        }

        public static void UpdateUser(AbstractUser user)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            string restaurantId = "NULL";
            if (user.RestaurantId != 0)
                restaurantId = "" + user.RestaurantId;
            command.CommandText = String.Format("UPDATE [dbo].[Users] SET [Username] = '{0}', [Password] = '{1}', [FirstName] = '{2}', [LastName] = '{3}', [Email] = '{4}', " +
                                                "[Membership] = {5}, [RestaurantId] = {6}, [RestaurantAdmin] = {7}, [SystemAdmin] = {8}, [Deleted] = {9} WHERE [Id] = {10}",
                                                user.Username, user.Password, user.FirstName, user.LastName, user.Email, user.Membership, restaurantId,
                                                user.RestaurantAdmin?"1":"0", user.SystemAdmin?"1":"0", user.Deleted?"1":"0", user.Id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($"({result} row(s) affected)");
        }

        #endregion
        #region SELECT / GET

        public static Order GetOrder(int id)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"SELECT * FROM [dbo].[Orders] WHERE [Id] = {id} AND [Cancelled] = 0";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            Order order = new Order();
            while (reader.Read())
            {
                order.Id = (int)reader["Id"];
                order.UserId = (int)reader["User"];
                order.RestaurantId = (int)reader["Restaurant"];
                order.Address = (string)reader["Address"];
                order.Cost = Convert.ToDouble(reader["Cost"]);
                order.Cancelled = (bool)reader["Cancelled"];
                for (int i = 0; i < 8; i++)
                {
                    if (!reader.IsDBNull(3 + i))
                        order.Add(GetFoodItem((int)reader["Item" + i]));
                }
            }
            connection.Close();
            return order;
        }

        public static Restaurant.Restaurant GetRestaurant(int id, string name = "")
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            string restaurantName = name;
            if (!name.Equals(""))
            {
                if (restaurantName.Contains("'"))
                    restaurantName = restaurantName.Replace("'", "''");
                command.CommandText = $"SELECT TOP 1 * FROM [dbo].[Restaurants] WHERE [Name] = '{restaurantName}' AND [Deleted] = 0";
            }
            else
                command.CommandText = $"SELECT * FROM [dbo].[Restaurants] WHERE [Id] = {id} AND [Deleted] = 0";
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
            command.CommandText = $"SELECT * FROM [dbo].[Items] WHERE [Id] = {id} AND [Deleted] = 0";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            FoodItem foodItem = new FoodItem();
            if (reader.Read())
                foodItem = new FoodItem(reader.GetInt32(0), reader.GetString(1), Convert.ToDouble(reader[2]), reader.GetInt32(3), Convert.ToDouble(reader[4])*UI.StaticAccessor.Discounts[3],
                    Convert.ToDouble(reader[4])*UI.StaticAccessor.Discounts[2], Convert.ToDouble(reader[4])*UI.StaticAccessor.Discounts[3], reader.GetBoolean(5));
            connection.Close();
            return foodItem;
        }

        public static AbstractUser GetUser(int id, string username = "", string email = "", int restaurantId = 0, string restaurantName = "")
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            string restaurant = restaurantName;
            if (!username.Equals(""))
                command.CommandText = $"SELECT TOP 1 * FROM [dbo].[Users] WHERE [dbo].[Users].[Username] = '{username}' AND [Deleted] = 0";
            else if (!email.Equals(""))
                command.CommandText = $"SELECT TOP 1 * FROM [dbo].[Users] WHERE [Email] = '{email}' AND [Deleted] = 0";
            else if (restaurantId != 0)
                command.CommandText = $"SELECT * FROM [dbo].[Users] JOIN [dbo].[Restaurants] ON [dbo].[Restaurants].[Id] = [dbo].[Users].[RestaurantId] WHERE [dbo].[Restaurants].[Id] = {restaurantId} AND [dbo].[Users].[Deleted] = 0";
            else if (!restaurantName.Equals(""))
            {
                if (restaurant.Contains("'"))
                    restaurant = restaurant.Replace("'", "''");
                command.CommandText = $"SELECT TOP 1 * FROM [dbo].[Users] JOIN [dbo].[Restaurants] ON [dbo].[Users].[RestaurantId] = [dbo].[Restaurants].[Id] WHERE [dbo].[Restaurants].[Name] = '{restaurant}' AND [dbo].[Users].[Deleted] = 0";
            }
            else
                command.CommandText = $"SELECT * FROM [dbo].[Users] WHERE [Id] = {id} AND [Deleted] = 0";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            AbstractUser user = new User.User();
            if (reader.Read())
            {
                string userType = "User";
                if (reader.GetBoolean(8))
                    userType = "RestAdmin";
                else if (reader.GetBoolean(9))
                    userType = "SysAdmin";
                int restId = 0;
                if (!reader.IsDBNull(7))
                    restId = reader.GetInt32(7);
                user = new UserFactory().GetUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetString(5), reader.GetInt32(6), userType, restId, reader.GetBoolean(8), reader.GetBoolean(9), reader.GetBoolean(10));
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

        public static List<Order> GetOrders(int userId = 0, int restaurantId = 0)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            if (userId > 0)
                command.CommandText = $"SELECT * FROM [dbo].[Orders] WHERE [User] = {userId}";
            else if (restaurantId > 0)
                command.CommandText = $"SELECT * FROM [dbo].[Orders] WHERE [Restaurant] = {restaurantId}";
            else
                command.CommandText = "SELECT * FROM [dbo].[Orders]";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            List<Order> orders = new List<Order>();
            while (reader.Read())
            {
                Order order = new Order();
                order.Id = (int)reader["Id"];
                order.UserId = (int)reader["User"];
                order.RestaurantId = (int)reader["Restaurant"];
                order.Address = (string)reader["Address"];
                order.Cost = Convert.ToDouble(reader["Cost"]);
                order.Cancelled = (bool)reader["Cancelled"];
                for (int i = 0; i < 8; i++)
                {
                    if (!reader.IsDBNull(3+i))
                    order.Add(GetFoodItem((int)reader["Item" + i]));
                }
                orders.Add(order);
            }
            connection.Close();
            return orders;
        }

        public static List<Restaurant.Restaurant> GetRestaurants()
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Restaurants] WHERE [Deleted] = 0";
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

        public static List<FoodItem> GetFoodItems(int restaurantId = 0)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            if (restaurantId > 0)
                command.CommandText = $"SELECT * FROM [dbo].[Items] WHERE [Deleted] <> 'true' AND [Restaurant] = {restaurantId}";
            else
                command.CommandText = "SELECT * FROM [dbo].[Items] WHERE [Deleted] = 0";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            List<FoodItem> foodItems = new List<FoodItem>();
            while (reader.Read())
            {
                FoodItem foodItem = new FoodItem(reader.GetInt32(0), reader.GetString(1), Convert.ToDouble(reader[2]), reader.GetInt32(3), Convert.ToDouble(reader[4])*UI.StaticAccessor.Discounts[1],
                    Convert.ToDouble(reader[4])*UI.StaticAccessor.Discounts[2], Convert.ToDouble(reader[4])*UI.StaticAccessor.Discounts[3], reader.GetBoolean(5));
                foodItems.Add(foodItem);
            }
            connection.Close();
            return foodItems;
        }

        public static List<AbstractUser> GetUsers(bool restaurantAdmins = false)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            if (restaurantAdmins)
                command.CommandText = "SELECT * FROM [dbo].[Users] WHERE [RestaurantAdmin] = 1 AND [Deleted] = 0";
            else
                command.CommandText = "SELECT * FROM [dbo].[Users] WHERE [Deleted] = 0";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            List<AbstractUser> users = new List<AbstractUser>();
            while (reader.Read())
            {
                AbstractUser user = new User.User();
                string userType = "User";
                if (reader.GetBoolean(8))
                    userType = "RestAdmin";
                else if (reader.GetBoolean(9))
                    userType = "SysAdmin";
                int restaurantId = 0;
                if (!reader.IsDBNull(7))
                    restaurantId = reader.GetInt32(7);
                user = new UserFactory().GetUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetString(5), reader.GetInt32(6), userType, restaurantId, reader.GetBoolean(8), reader.GetBoolean(9), reader.GetBoolean(10));
                users.Add(user);
            }
            connection.Close();
            return users;
        }

        #endregion
    }
}
