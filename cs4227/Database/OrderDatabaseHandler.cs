using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using cs4227.Restaurant;

namespace cs4227.Database
{
    public class OrderDatabaseHandler
    {
        public static void InsertOrder(Order order)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            command.CommandText = string.Format("INSERT INTO [dbo].[Orders] VALUES ({0}, {1}, ", order.UserId,
                order.RestaurantId);
            for (var index = 0; index < 8; index++)
                if (index < order.FoodItems.Count)
                    command.CommandText += $"{order.FoodItems[index].Id}, ";
                else
                    command.CommandText += "NULL, ";
            command.CommandText +=
                string.Format("{0}, '{1}', {2})", order.Cost, order.Address, order.Cancelled ? "1" : "0");
            command.Connection = connection;
            var result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static void UpdateOrder(Order order)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            command.CommandText = string.Format("UPDATE [dbo].[Orders] SET [User] = {0}, [Restaurant] = {1}, ",
                order.UserId, order.RestaurantId);
            for (var index = 0; index < 8; index++)
                if (index < order.FoodItems.Count)
                    command.CommandText += $"[Item{index}] = {order.FoodItems[index].Id}, ";
                else
                    command.CommandText += $"[Item{index}] = NULL, ";
            command.CommandText += string.Format("[Cancelled] = {0}, [Address] = '{1}', [Cost] = {2} WHERE [Id] = {3}",
                order.Cancelled ? 1 : 0, order.Address, order.Cost, order.Id);
            command.Connection = connection;
            var result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static Order GetOrder(int id, bool includeCancelled = false)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            if (includeCancelled)
                command.CommandText = $"SELECT * FROM [dbo].[Orders] WHERE [Id] = {id}";
            else
                command.CommandText = $"SELECT * FROM [dbo].[Orders] WHERE [Id] = {id} AND [Cancelled] = 0";
            command.Connection = connection;
            var reader = command.ExecuteReader();
            var order = new Order();
            while (reader.Read())
            {
                order.Id = (int) reader["Id"];
                order.UserId = (int) reader["User"];
                order.RestaurantId = (int) reader["Restaurant"];
                order.Address = (string) reader["Address"];
                order.Cost = Convert.ToDouble(reader["Cost"]);
                order.Cancelled = (bool) reader["Cancelled"];
                for (var i = 0; i < 8; i++)
                    if (!reader.IsDBNull(3 + i))
                        order.Add(FoodItemDatabaseHandler.GetFoodItem((int) reader["Item" + i], true));
            }
            connection.Close();
            return order;
        }

        public static List<Order> GetOrders(int userId = 0, int restaurantId = 0)
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            if (userId > 0)
                command.CommandText = $"SELECT * FROM [dbo].[Orders] WHERE [User] = {userId}";
            else if (restaurantId > 0)
                command.CommandText = $"SELECT * FROM [dbo].[Orders] WHERE [Restaurant] = {restaurantId}";
            else
                command.CommandText = "SELECT * FROM [dbo].[Orders]";
            command.Connection = connection;
            var reader = command.ExecuteReader();
            var orders = new List<Order>();
            while (reader.Read())
            {
                var order = new Order();
                order.Id = (int) reader["Id"];
                order.UserId = (int) reader["User"];
                order.RestaurantId = (int) reader["Restaurant"];
                order.Address = (string) reader["Address"];
                order.Cost = Convert.ToDouble(reader["Cost"]);
                order.Cancelled = (bool) reader["Cancelled"];
                for (var i = 0; i < 8; i++)
                    if (!reader.IsDBNull(3 + i))
                        order.Add(FoodItemDatabaseHandler.GetFoodItem((int) reader["Item" + i], true));
                orders.Add(order);
            }
            connection.Close();
            return orders;
        }

        public static int GetNewestOrderId()
        {
            var connection = DatabaseHandler.GetLocalDbConnection();
            var command = new SqlCommand();
            command.CommandText = "SELECT Max([Id]) FROM [dbo].[Orders]";
            command.Connection = connection;
            var reader = command.ExecuteReader();
            var result = 0;
            if (reader.Read())
                result = reader.GetInt32(0);
            connection.Close();
            return result;
        }
    }
}