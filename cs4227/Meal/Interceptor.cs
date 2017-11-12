using cs4227.UI;

namespace cs4227.Interceptor
{
    internal interface Interceptor
    {
        void LoginRegister(LoginMenuV2 reference);
        void OrderLog();
    }
}