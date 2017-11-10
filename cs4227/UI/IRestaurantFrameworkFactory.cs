namespace cs4227.UI
{
    public interface IRestaurantFrameworkFactory
    {
        LoginMenuV2 GetLoginMenu(string appName = "Tap n' Eat");
    }
}