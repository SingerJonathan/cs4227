using System;
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

        // ----------------------------------------
        // INSERT
        // ----------------------------------------
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
            command.CommandText = "INSERT INTO [dbo].[Users] VALUES (" + user.Id + ", '" + user.Username + "', '" + user.Password + "', '" + user.FirstName +
                "', '" + user.LastName + "', '" + user.Email + "', " + user.RestaurantAdmin + ", " + user.SystemAdmin + ", " + user.Deleted;
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        // ----------------------------------------
        // UPDATE
        // ----------------------------------------
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
            command.CommandText += "[Cancelled] = "+(order.Cancelled ? 1 : 0)+", [Address] = "+order.Address+", [Cost] = "+order.Cost + " WHERE Id = " + order.Id;
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        public static void UpdateFoodItem(FoodItem item)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE [dbo].[Items] SET [Id] = " + item.Id + ", [Name] = '" + item.Name +
                "', [Cost] = " + item.Cost +", [Restaurant] = " + item.RestaurantId + ", [Deleted] = " + item.Deleted;
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        public static void UpdateUser(AbstractUser user)
        {
            SqlConnection connection = GetLocalDBConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE [dbo].[Users] SET [Id] = " + user.Id + ", [Username] = '" + user.Username + "', [Password] = '" + user.Password +
                "', [FirstName] = '" + user.FirstName + "', [LastName] = '" + user.LastName + "', [Email] = '" + user.Email + "', [RestaurantAdmin] = " +user.RestaurantAdmin +
                ", [SystemAdmin] = " + user.SystemAdmin + ", [Deleted] = " + user.Deleted;
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("(" + result + " row(s) affected)");
        }

        // ----------------------------------------
        // SELECT / GET
        // ----------------------------------------
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
                user = new UserFactory().getUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetBoolean(8), reader.GetBoolean(9));
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
    }
}
