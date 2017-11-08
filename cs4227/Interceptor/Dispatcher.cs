using cs4227.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4227.Interceptor
{
    class Dispatcher
    {
        List<LoginInterceptor> list = new List<LoginInterceptor>();

        public void RegisterInterceptor(LoginInterceptor interceptor)
        {
            list.Add(interceptor);
        }

        public void RemoveInterceptor(LoginInterceptor interceptor)
        {
            list.Remove(interceptor);
        }

        public void DispatchLoginInterceptor(LoginInterceptor interceptor, LoginMenuV2 reference)
        {
            interceptor.LoginRegister(reference);
        }
    }
}
