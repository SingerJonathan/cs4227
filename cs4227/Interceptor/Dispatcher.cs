using cs4227.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4227.Interceptor
{
    class Dispatcher
    {
        List<Interceptor> list = new List<Interceptor>();

        public void RegisterInterceptor(Interceptor interceptor)
        {
            list.Add(interceptor);
        }

        public void RemoveInterceptor(Interceptor interceptor)
        {
            list.Remove(interceptor);
        }

        public void DispatchLoginInterceptor(Interceptor interceptor, LoginMenuV2 reference)
        {
            interceptor.LoginRegister(reference);
        }

        public void DispatchOrderInterceptor(Interceptor interceptor)
        {
            interceptor.OrderLog();
        }
    }
}
