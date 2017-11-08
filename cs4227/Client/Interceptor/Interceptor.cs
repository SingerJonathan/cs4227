using cs4227.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4227.Interceptor
{
    interface Interceptor
    {
        void LoginRegister(LoginMenuV2 reference);
        void OrderLog();
    }
}
