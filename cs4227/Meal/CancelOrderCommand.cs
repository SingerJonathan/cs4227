using System;
using cs4227.Restaurant;
using cs4227.UI;

namespace cs4227.Meal
{
    internal class CancelOrderCommand : Command
    {
        private readonly Order order;

        public CancelOrderCommand(Order order)
        {
            this.order = order;
        }

        void Command.Execute()
        {
            order.Cancelled = true;
            StaticAccessor.DB.UpdateOrder(order);
            Console.WriteLine(@"Order " + order.Id + @" cancelled");
        }
    }
}