using System;
using cs4227.Restaurant;
using cs4227.UI;
using cs4227.Client;

namespace cs4227.Meal
{
    internal class PlaceOrderCommand : Command
    {
        private readonly Order order;

        public PlaceOrderCommand(Order order)
        {
            this.order = order;
        }

        void Command.Execute()
        {
            var orderId = StaticAccessor.DB.GetNewestOrderId() + 1;
            StaticAccessor.DB.InsertOrder(order);
            Console.WriteLine(@"Order " + orderId + @" placed");
            Interceptor interceptor = new ConcreteOrderInterceptor();
            var dispatcher = new Dispatcher();
            dispatcher.DispatchOrderInterceptor(interceptor);
        }
    }
}