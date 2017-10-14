using System;
using cs4227.Restaurant;
using cs4227.Database;

namespace cs4227.Meal
{
    class InvokerTest
    {
        static void Main()
        {
            Invoker invoker = new Invoker();

            int newestId = DatabaseHandler.GetNewestOrderId();
            Console.WriteLine("Newest Order ID = " + newestId);

            Order order = new Order();
            order.setId(newestId + 1);
            order.setUserId(8);
            order.Add(DatabaseHandler.GetFoodItem(1));
            order.Add(DatabaseHandler.GetFoodItem(2));
            order.Add(DatabaseHandler.GetFoodItem(3));
            order.Add(DatabaseHandler.GetFoodItem(1));
            order.Add(DatabaseHandler.GetFoodItem(1));
            order.Add(DatabaseHandler.GetFoodItem(3));

            PlaceOrderCommand placeOrderCommand = new PlaceOrderCommand(order);
            CancelOrderCommand cancelOrderCommand = new CancelOrderCommand(order);

            invoker.setCommand(placeOrderCommand);
            invoker.Invoke();

            invoker.setCommand(cancelOrderCommand);
            invoker.Invoke();
        }
    }
}
