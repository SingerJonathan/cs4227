using System;
using cs4227.Restaurant;
using cs4227.Database;

namespace cs4227.Meal
{
    class PlaceOrderCommand : Command
    {
        private Order order;

        public PlaceOrderCommand(Order order)
        {
            this.order = order;
        }

        void Command.Execute()
        {
            int orderId = DatabaseHandler.GetNewestOrderId() + 1;
            DatabaseHandler.InsertOrder(order);
            Console.WriteLine("Order "+ orderId + " placed");
        }
    }
}
