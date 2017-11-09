using cs4227.Restaurant;
using cs4227.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace cs4227.Database
{
    class DatabaseHandler : IDatabaseHandler
    {
        private const string DbName = "Database";

        public static SqlConnection GetLocalDbConnection()
        {
            string outputFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dbFileName = Path.Combine(outputFolder, $"{DbName}.mdf");
            string logFileName = Path.Combine(outputFolder, $"{DbName}_log.ldf");

            string connectionString = String.Format(@"Data Source=(LocalDB)\v11.0;AttachDBFileName={1};Initial Catalog={0};Integrated Security=True;", DbName, dbFileName);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void InsertOrder(Order order)
        {
            OrderDatabaseHandler.InsertOrder(order);
        }

        public void InsertRestaurant(Restaurant.Restaurant restaurant)
        {
            RestaurantDatabaseHandler.InsertRestaurant(restaurant);
        }

        public void InsertFoodItem(FoodItem item)
        {
            FoodItemDatabaseHandler.InsertFoodItem(item);
        }

        public void InsertUser(AbstractUser user)
        {
            UserDatabaseHandler.InsertUser(user);
        }

        public void UpdateOrder(Order order)
        {
            OrderDatabaseHandler.UpdateOrder(order);
        }

        public void UpdateRestaurant(Restaurant.Restaurant restaurant)
        {
            RestaurantDatabaseHandler.UpdateRestaurant(restaurant);
        }

        public void UpdateFoodItem(FoodItem item)
        {
            FoodItemDatabaseHandler.UpdateFoodItem(item);
        }

        public void UpdateUser(AbstractUser user)
        {
            UserDatabaseHandler.UpdateUser(user);
        }

        public Order GetOrder(int id)
        {
            return OrderDatabaseHandler.GetOrder(id);
        }

        public Restaurant.Restaurant GetRestaurant(int id, string name = "")
        {
            return RestaurantDatabaseHandler.GetRestaurant(id, name);
        }

        public FoodItem GetFoodItem(int id)
        {
            return FoodItemDatabaseHandler.GetFoodItem(id);
        }

        public AbstractUser GetUser(int id, string username = "", string email = "", int restaurantId = 0, string restaurantName = "")
        {
            return UserDatabaseHandler.GetUser(id, username, email, restaurantId, restaurantName);
        }

        public int GetNewestOrderId()
        {
            return OrderDatabaseHandler.GetNewestOrderId();
        }

        public List<Order> GetOrders(int userId = 0, int restaurantId = 0)
        {
            return OrderDatabaseHandler.GetOrders(userId, restaurantId);
        }

        public List<Restaurant.Restaurant> GetRestaurants()
        {
            return RestaurantDatabaseHandler.GetRestaurants();
        }

        public List<FoodItem> GetFoodItems(int restaurantId = 0)
        {
            return FoodItemDatabaseHandler.GetFoodItems(restaurantId);
        }

        public List<AbstractUser> GetUsers(bool restaurantAdmins = false)
        {
            return UserDatabaseHandler.GetUsers(restaurantAdmins);
        }
    }
}
