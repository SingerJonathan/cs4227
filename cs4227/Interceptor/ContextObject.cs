using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs4227.User;
using cs4227.UI;

namespace cs4227.Interceptor
{
    class ContextObject
    {
        public string LoginContext(LoginMenuV2 reference)
        {
            return reference.UsernameTextBox();
        }
    }
}
