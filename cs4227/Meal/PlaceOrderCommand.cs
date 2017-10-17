using System;
using cs4227.Restaurant;

namespace cs4227.Meal
{
    class PlaceOrderCommand : Command
    {
        Order order;

        public PlaceOrderCommand(Order order)
        {
            this.order = order;
        }

        void Command.Execute()
        {
            Database.DatabaseHandler.InsertOrder(order);
            Console.WriteLine("Order "+order.GetId()+" placed");
            Console.ReadKey();
        }
    }
}
