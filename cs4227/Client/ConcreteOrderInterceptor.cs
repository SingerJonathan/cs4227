using System;
using System.IO;
using cs4227.UI;
using cs4227.Meal;

namespace cs4227.Client
{
    internal class ConcreteOrderInterceptor : Interceptor
    {
        public void OrderLog()
        {
            Console.WriteLine(@"Check 1");
            var OrderDetails = new ContextObject();
            var order = OrderDetails.OrderContext();
            var FileName = "orders.txt";
            var OrderTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            try
            {
                if (!File.Exists(FileName))
                {
                    File.Create(FileName).Close();
                    TextWriter tw = new StreamWriter(FileName);
                    tw.WriteLine(order.Id + ", Restaurant ID: " + order.RestaurantId + ", User ID: " + order.UserId +
                                 ", " + OrderTime);
                    tw.Close();
                }
                else
                {
                    TextWriter tw = new StreamWriter(FileName, true);
                    Console.WriteLine(@"Check 4");
                    tw.WriteLine(order.Id + ", Restaurant ID: " + order.RestaurantId + ", User ID: " + order.UserId +
                                 ", " + OrderTime);
                    Console.WriteLine(@"Check 5");
                    tw.Close();
                }
                Console.WriteLine(@"Interceptor for logging orders invoked");
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        public void LoginRegister(LoginMenuV2 reference)
        {
        }
    }
}