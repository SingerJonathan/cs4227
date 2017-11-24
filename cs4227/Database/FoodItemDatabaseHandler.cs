using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using cs4227.Restaurant;
using cs4227.UI;

namespace cs4227.Database
{
    internal class FoodItemDatabaseHandler
    {
        public static void InsertFoodItem(FoodItem item)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            command.CommandText = string.Format("INSERT INTO [dbo].[Items] VALUES ('{0}', {1}, {2}, {3}, {4})",
                item.Name, item.Cost, item.RestaurantId, item.Discounts[1], item.Deleted ? "1" : "0");
            command.Connection = connection;
            var result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static void UpdateFoodItem(FoodItem item)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            command.CommandText = string.Format(
                "UPDATE [dbo].[Items] SET [Name] = '{0}', [Cost] = {1}, [Restaurant] = {2}, [BronzeDiscount] = {3}, [Deleted] = {4} WHERE [Id] = {5}",
                item.Name, item.Cost, item.RestaurantId, item.Discounts[1], item.Deleted ? "1" : "0", item.Id);
            command.Connection = connection;
            var result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static FoodItem GetFoodItem(int id, bool includeDeleted = false)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            if (includeDeleted)
                command.CommandText = $"SELECT * FROM [dbo].[Items] WHERE [Id] = {id}";
            else
                command.CommandText = $"SELECT * FROM [dbo].[Items] WHERE [Id] = {id} AND [Deleted] = 0";
            command.Connection = connection;
            var reader = command.ExecuteReader();
            var foodItem = new FoodItem();
            if (reader.Read())
                foodItem = new FoodItem(reader.GetInt32(0), reader.GetString(1), Convert.ToDouble(reader[2]),
                    reader.GetInt32(3), Convert.ToDouble(reader[4]) * StaticAccessor.Discounts[3],
                    Convert.ToDouble(reader[4]) * StaticAccessor.Discounts[2],
                    Convert.ToDouble(reader[4]) * StaticAccessor.Discounts[3], reader.GetBoolean(5));
            connection.Close();
            return foodItem;
        }

        public static List<FoodItem> GetFoodItems(int restaurantId = 0)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            if (restaurantId > 0)
                command.CommandText =
                    $"SELECT * FROM [dbo].[Items] WHERE [Deleted] <> 'true' AND [Restaurant] = {restaurantId}";
            else
                command.CommandText = "SELECT * FROM [dbo].[Items] WHERE [Deleted] = 0";
            command.Connection = connection;
            var reader = command.ExecuteReader();
            var foodItems = new List<FoodItem>();
            while (reader.Read())
            {
                var foodItem = new FoodItem(reader.GetInt32(0), reader.GetString(1), Convert.ToDouble(reader[2]),
                    reader.GetInt32(3), Convert.ToDouble(reader[4]) * StaticAccessor.Discounts[1],
                    Convert.ToDouble(reader[4]) * StaticAccessor.Discounts[2],
                    Convert.ToDouble(reader[4]) * StaticAccessor.Discounts[3], reader.GetBoolean(5));
                foodItems.Add(foodItem);
            }
            connection.Close();
            return foodItems;
        }
    }
}