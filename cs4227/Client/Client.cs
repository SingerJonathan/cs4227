using cs4227.UI;

namespace cs4227.Client
{
    internal class Client
    {
        public static void Main()
        {
            IRestaurantFrameworkFactory restaurantFramework = new RestaurantFrameworkFactory();
            restaurantFramework.GetLoginMenu();
        }
    }
}