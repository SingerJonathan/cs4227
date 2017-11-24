using System.Collections.Generic;
using cs4227.Restaurant;
using cs4227.User;

namespace cs4227.Database
{
    public interface IDatabaseHandler
    {
        void InsertOrder(Order order);
        void InsertRestaurant(Restaurant.Restaurant restaurant);
        void InsertFoodItem(FoodItem item);
        void InsertUser(AbstractUser user);
        void UpdateOrder(Order order);
        void UpdateRestaurant(Restaurant.Restaurant restaurant);
        void UpdateFoodItem(FoodItem item);
        void UpdateUser(AbstractUser user);
        Order GetOrder(int id, bool includeCancelled = false);
        Restaurant.Restaurant GetRestaurant(int id, string name = "");
        FoodItem GetFoodItem(int id, bool includeDeleted = false);

        AbstractUser GetUser(int id, string username = "", string email = "", int restaurantId = 0,
            string restaurantName = "");

        int GetNewestOrderId();
        List<Order> GetOrders(int userId = 0, int restaurantId = 0);
        List<Restaurant.Restaurant> GetRestaurants();
        List<FoodItem> GetFoodItems(int restaurantId = 0);
        List<AbstractUser> GetUsers(bool restaurantAdmins = false);
    }
}