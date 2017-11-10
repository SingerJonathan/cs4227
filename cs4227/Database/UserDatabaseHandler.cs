using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using cs4227.User;

namespace cs4227.Database
{
    internal class UserDatabaseHandler
    {
        public static void InsertUser(AbstractUser user)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            var restaurantId = "NULL";
            if (user.RestaurantId != 0)
                restaurantId = "" + user.RestaurantId;
            command.CommandText = string.Format(
                "INSERT INTO [dbo].[Users] VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, {8}, {9})",
                user.Username, user.Password, user.FirstName, user.LastName, user.Email, user.Membership,
                restaurantId, user.RestaurantAdmin ? "1" : "0", user.SystemAdmin ? "1" : "0", user.Deleted ? "1" : "0");
            command.Connection = connection;
            var result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static void UpdateUser(AbstractUser user)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            var restaurantId = "NULL";
            if (user.RestaurantId != 0)
                restaurantId = "" + user.RestaurantId;
            command.CommandText = string.Format(
                "UPDATE [dbo].[Users] SET [Username] = '{0}', [Password] = '{1}', [FirstName] = '{2}', [LastName] = '{3}', [Email] = '{4}', " +
                "[Membership] = {5}, [RestaurantId] = {6}, [RestaurantAdmin] = {7}, [SystemAdmin] = {8}, [Deleted] = {9} WHERE [Id] = {10}",
                user.Username, user.Password, user.FirstName, user.LastName, user.Email, user.Membership, restaurantId,
                user.RestaurantAdmin ? "1" : "0", user.SystemAdmin ? "1" : "0", user.Deleted ? "1" : "0", user.Id);
            command.Connection = connection;
            var result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static AbstractUser GetUser(int id, string username = "", string email = "", int restaurantId = 0,
            string restaurantName = "")
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            var restaurant = restaurantName;
            if (!username.Equals(""))
            {
                command.CommandText =
                    $"SELECT TOP 1 * FROM [dbo].[Users] WHERE [dbo].[Users].[Username] = '{username}' AND [Deleted] = 0";
            }
            else if (!email.Equals(""))
            {
                command.CommandText = $"SELECT TOP 1 * FROM [dbo].[Users] WHERE [Email] = '{email}' AND [Deleted] = 0";
            }
            else if (restaurantId != 0)
            {
                command.CommandText =
                    $"SELECT * FROM [dbo].[Users] JOIN [dbo].[Restaurants] ON [dbo].[Restaurants].[Id] = [dbo].[Users].[RestaurantId] WHERE [dbo].[Restaurants].[Id] = {restaurantId} AND [dbo].[Users].[Deleted] = 0";
            }
            else if (!restaurantName.Equals(""))
            {
                if (restaurant.Contains("'"))
                    restaurant = restaurant.Replace("'", "''");
                command.CommandText =
                    $"SELECT TOP 1 * FROM [dbo].[Users] JOIN [dbo].[Restaurants] ON [dbo].[Users].[RestaurantId] = [dbo].[Restaurants].[Id] WHERE [dbo].[Restaurants].[Name] = '{restaurant}' AND [dbo].[Users].[Deleted] = 0";
            }
            else
            {
                command.CommandText = $"SELECT * FROM [dbo].[Users] WHERE [Id] = {id} AND [Deleted] = 0";
            }
            command.Connection = connection;
            var reader = command.ExecuteReader();
            AbstractUser user = new User.User();
            if (reader.Read())
            {
                var userType = "User";
                if (reader.GetBoolean(8))
                    userType = "RestAdmin";
                else if (reader.GetBoolean(9))
                    userType = "SysAdmin";
                var restId = 0;
                if (!reader.IsDBNull(7))
                    restId = reader.GetInt32(7);
                user = new UserFactory().GetUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4),
                    reader.GetString(5), reader.GetInt32(6), userType, restId, reader.GetBoolean(8),
                    reader.GetBoolean(9), reader.GetBoolean(10));
            }
            connection.Close();
            return user;
        }

        public static List<AbstractUser> GetUsers(bool restaurantAdmins = false)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            if (restaurantAdmins)
                command.CommandText = "SELECT * FROM [dbo].[Users] WHERE [RestaurantAdmin] = 1 AND [Deleted] = 0";
            else
                command.CommandText = "SELECT * FROM [dbo].[Users] WHERE [Deleted] = 0";
            command.Connection = connection;
            var reader = command.ExecuteReader();
            var users = new List<AbstractUser>();
            while (reader.Read())
            {
                AbstractUser user = new User.User();
                var userType = "User";
                if (reader.GetBoolean(8))
                    userType = "RestAdmin";
                else if (reader.GetBoolean(9))
                    userType = "SysAdmin";
                var restaurantId = 0;
                if (!reader.IsDBNull(7))
                    restaurantId = reader.GetInt32(7);
                user = new UserFactory().GetUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4),
                    reader.GetString(5), reader.GetInt32(6), userType, restaurantId, reader.GetBoolean(8),
                    reader.GetBoolean(9), reader.GetBoolean(10));
                users.Add(user);
            }
            connection.Close();
            return users;
        }
    }
}