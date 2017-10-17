using System;
using cs4227.Restaurant;
using cs4227.Database;
using System.Collections.Generic;

namespace cs4227.Meal
{
    class InvokerTest
    {
        static void Main()
        {
            Invoker invoker = new Invoker();
            List<Memento> mementos = new List<Memento>();

            int newestId = DatabaseHandler.GetNewestOrderId();
            Console.WriteLine("Newest Order ID = " + newestId);

            Order order = new Order();
            order.setId(newestId + 1);
            order.setUserId(8);
            order.Add(DatabaseHandler.GetFoodItem(1));
            mementos.Add(order.saveToMemento());
            order.Add(DatabaseHandler.GetFoodItem(2));
            mementos.Add(order.saveToMemento());
            order.Add(DatabaseHandler.GetFoodItem(3));
            mementos.Add(order.saveToMemento());
            order.Add(DatabaseHandler.GetFoodItem(1));
            mementos.Add(order.saveToMemento());
            order.Add(DatabaseHandler.GetFoodItem(1));
            mementos.Add(order.saveToMemento());
            order.Add(DatabaseHandler.GetFoodItem(3));
            mementos.Add(order.saveToMemento());

            PlaceOrderCommand placeOrderCommand = new PlaceOrderCommand(order);
            CancelOrderCommand cancelOrderCommand = new CancelOrderCommand(order);

            invoker.setCommand(placeOrderCommand);
            invoker.Invoke();

            invoker.setCommand(cancelOrderCommand);
            invoker.Invoke();
        }
    }
}
