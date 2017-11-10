using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using cs4227.Restaurant;

namespace cs4227.Database
{
    class OrderDatabaseHandler
    {
        public static void InsertOrder(Order order)
        {
            SqlConnection connection = DatabaseHandler.GetLocalDbConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("INSERT INTO [dbo].[Orders] VALUES ({0}, {1}, ", order.UserId, order.RestaurantId);
            for (int index = 0; index < 8; index++)
            {
                if (index < order.FoodItems.Count)
                    command.CommandText += $"{order.FoodItems[index].Id}, ";
                else
                    command.CommandText += "NULL, ";
            }
            command.CommandText += String.Format("{0}, '{1}', {2})", order.Cost, order.Address, order.Cancelled ? "1" : "0");
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static void UpdateOrder(Order order)
        {
            SqlConnection connection = DatabaseHandler.GetLocalDbConnection();
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
                order.Cancelled ? 1 : 0, order.Address, order.Cost);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine($@"({result} row(s) affected)");
        }

        public static Order GetOrder(int id)
        {
            SqlConnection connection = DatabaseHandler.GetLocalDbConnection();
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
                        order.Add(FoodItemDatabaseHandler.GetFoodItem((int)reader["Item" + i]));
                }
            }
            connection.Close();
            return order;
        }

        public static List<Order> GetOrders(int userId = 0, int restaurantId = 0)
        {
            SqlConnection connection = DatabaseHandler.GetLocalDbConnection();
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
                    if (!reader.IsDBNull(3 + i))
                        order.Add(FoodItemDatabaseHandler.GetFoodItem((int)reader["Item" + i]));
                }
                orders.Add(order);
            }
            connection.Close();
            return orders;
        }

        public static int GetNewestOrderId()
        {
            SqlConnection connection = DatabaseHandler.GetLocalDbConnection();
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
