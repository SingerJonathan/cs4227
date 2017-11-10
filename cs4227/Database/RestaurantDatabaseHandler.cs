using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace cs4227.Database
{
    internal class RestaurantDatabaseHandler
    {
        public static void InsertRestaurant(Restaurant.Restaurant restaurant)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            var restaurantName = restaurant.Name;
            if (restaurantName.Contains("'"))
                restaurantName = restaurantName.Replace("'", "''");
            command.CommandText = string.Format(
                "INSERT INTO [dbo].[Restaurants] VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10})",
                restaurantName, restaurant.Address, restaurant.OwnerId, restaurant.Phone, restaurant.Email,
                restaurant.OpeningHours,
                restaurant.ClosingHours, restaurant.Days, restaurant.Type, restaurant.Delivery,
                restaurant.Deleted ? "1" : "0");
            command.Connection = connection;
            var result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static void UpdateRestaurant(Restaurant.Restaurant restaurant)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            var restaurantName = restaurant.Name;
            if (restaurantName.Contains("'"))
                restaurantName = restaurantName.Replace("'", "''");
            command.CommandText = string.Format(
                "UPDATE [dbo].[Restaurants] SET [Name] = '{1}', [Address] = '{2}', [OwnerId] = {3}, [Phone] = '{4}', [Email] = '{5}', " +
                "[OpeningHours] = '{6}', [ClosingHours] = '{7}', [Days] = '{8}', [Type] = '{9}', [Delivery] = {10}, [Deleted] = {11} WHERE [Id] = {0}",
                restaurant.Id, restaurantName, restaurant.Address, restaurant.OwnerId, restaurant.Phone,
                restaurant.Email, restaurant.OpeningHours,
                restaurant.ClosingHours, restaurant.Days, restaurant.Type, restaurant.Delivery,
                restaurant.Deleted ? "1" : "0");
            command.Connection = connection;
            var result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static Restaurant.Restaurant GetRestaurant(int id, string name = "")
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            var restaurantName = name;
            if (!name.Equals(""))
            {
                if (restaurantName.Contains("'"))
                    restaurantName = restaurantName.Replace("'", "''");
                command.CommandText =
                    $"SELECT TOP 1 * FROM [dbo].[Restaurants] WHERE [Name] = '{restaurantName}' AND [Deleted] = 0";
            }
            else
            {
                command.CommandText = $"SELECT * FROM [dbo].[Restaurants] WHERE [Id] = {id} AND [Deleted] = 0";
            }
            command.Connection = connection;
            var reader = command.ExecuteReader();
            var restaurant = new Restaurant.Restaurant();
            if (reader.Read())
                restaurant = new Restaurant.Restaurant(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetInt32(3), reader.GetString(4),
                    reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8),
                    reader.GetString(9), Convert.ToDouble(reader[10]), reader.GetBoolean(11));
            connection.Close();
            return restaurant;
        }

        public static List<Restaurant.Restaurant> GetRestaurants()
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Restaurants] WHERE [Deleted] = 0";
            command.Connection = connection;
            var reader = command.ExecuteReader();
            var restaurants = new List<Restaurant.Restaurant>();
            while (reader.Read())
            {
                var restaurant = new Restaurant.Restaurant(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetInt32(3), reader.GetString(4),
                    reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8),
                    reader.GetString(9), Convert.ToDouble(reader[10]), reader.GetBoolean(11));
                restaurants.Add(restaurant);
            }
            connection.Close();
            return restaurants;
        }
    }
}