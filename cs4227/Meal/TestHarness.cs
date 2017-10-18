using System;
using System.Collections.Generic;
using cs4227.Restaurant;
using cs4227.Database;

namespace cs4227.Meal
{
    class TestHarness
    {
        static void Main()
        {
            Invoker invoker = new Invoker();
            List<Memento> mementos = new List<Memento>();

            int newestId = DatabaseHandler.GetNewestOrderId();
            Console.WriteLine("Newest Order ID = " + newestId);

            // Create order and create a memento each time an item is added
            Order order = new Order();
            order.Id = newestId + 1;
            order.UserId = 8;
            order.Add(DatabaseHandler.GetFoodItem(1));
            mementos.Add(order.CreateMemento());
            order.Add(DatabaseHandler.GetFoodItem(2));
            mementos.Add(order.CreateMemento());
            order.Add(DatabaseHandler.GetFoodItem(3));
            mementos.Add(order.CreateMemento());
            order.Add(DatabaseHandler.GetFoodItem(1));
            mementos.Add(order.CreateMemento());
            order.Add(DatabaseHandler.GetFoodItem(1));
            mementos.Add(order.CreateMemento());
            order.Add(DatabaseHandler.GetFoodItem(3));
            mementos.Add(order.CreateMemento());

            // Remove the last two items added to the order
            for (int i = 1; i <= 2; i++)
            {
                Memento currentMemento = mementos[mementos.Count-1 - i];
                order.SetMemento(currentMemento);

                Console.Write("Order set to Memento {0}: ", mementos.Count-i);
                for (int j = 0; j < currentMemento.foodItems.Count; j++)
                    Console.Write("{0}, ", currentMemento.foodItems[j].Name);
                Console.WriteLine();
            }

            // Create command objects
            PlaceOrderCommand placeOrderCommand = new PlaceOrderCommand(order);
            CancelOrderCommand cancelOrderCommand = new CancelOrderCommand(order);

            // Place and cancel the order using the command design pattern
            invoker.Command = placeOrderCommand;
            invoker.Invoke();
            invoker.Command = cancelOrderCommand;
            invoker.Invoke();
        }
    }
}
