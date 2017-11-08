using cs4227.Restaurant;
using cs4227.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4227.Interceptor.ConcreteInterceptor
{
    class ConcreteOrderInterceptor : Interceptor
    {
        public void OrderLog()
        {
            Console.WriteLine("Check 1");
            ContextObject OrderDetails = new ContextObject();
            Order order = OrderDetails.OrderContext();
            string FileName = "orders.txt";
            string OrderTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            try
            {
                if (!(File.Exists(FileName)))
                {
                    File.Create(FileName).Close();
                    TextWriter tw = new StreamWriter(FileName);
                    tw.WriteLine(order.Id + ", Restaurant ID: " + order.RestaurantId + ", User ID: " + order.UserId + ", " + OrderTime);
                    tw.Close();
                }
                else
                {
                    TextWriter tw = new StreamWriter(FileName, true);
                    Console.WriteLine("Check 4");
                    tw.WriteLine(order.Id + ", Restaurant ID: " + order.RestaurantId + ", User ID: " + order.UserId + ", " + OrderTime);
                    Console.WriteLine("Check 5");
                    tw.Close();
                }
            }
            catch (IOException e) { }
        }

        public void LoginRegister(LoginMenuV2 reference) { }
    }
}
