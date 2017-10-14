using System;
using cs4227.Restaurant;

namespace cs4227.Meal
{
    class CancelOrderCommand : Command
    {
        Order order;

        public CancelOrderCommand(Order order)
        {
            this.order = order;
        }

        void Command.Execute()
        {
            order.setCancelled(true);
            Database.DatabaseHandler.UpdateOrder(order);
            Console.WriteLine("Order " + order.getId() + " cancelled");
            Console.ReadKey();
        }
    }
}
