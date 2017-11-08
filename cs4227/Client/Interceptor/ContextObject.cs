using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs4227.User;
using cs4227.UI;
using cs4227.Restaurant;
using cs4227.Database;

namespace cs4227.Interceptor
{
    class ContextObject
    {
        public string LoginContext(LoginMenuV2 reference)
        {
            return reference.UsernameTextBox();
        }

        public Order OrderContext()
        {
            int id = DatabaseHandler.GetNewestOrderId();
            return DatabaseHandler.GetOrder(id);
        }
    }
}
