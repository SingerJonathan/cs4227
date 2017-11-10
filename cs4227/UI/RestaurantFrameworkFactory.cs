using System;
using cs4227.Meal;

namespace cs4227.UI
{
    public class RestaurantFrameworkFactory : IRestaurantFrameworkFactory
    {
        public LoginMenuV2 GetLoginMenu(string appName = "Tap n' Eat")
        {
            StaticAccessor.Invoker = new Invoker();
            StaticAccessor.AppName = appName;
            Console.WriteLine($"Login menu with AppName \"{appName}\" created by Factory");
            return new LoginMenuV2();
        }
    }
}