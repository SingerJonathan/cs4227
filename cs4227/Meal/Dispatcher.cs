using System.Collections.Generic;
using cs4227.UI;

namespace cs4227.Meal
{
    internal class Dispatcher
    {
        private readonly List<Interceptor> _list = new List<Interceptor>();

        public void RegisterInterceptor(Interceptor interceptor)
        {
            _list.Add(interceptor);
        }

        public void RemoveInterceptor(Interceptor interceptor)
        {
            _list.Remove(interceptor);
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