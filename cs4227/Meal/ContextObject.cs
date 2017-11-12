using cs4227.Restaurant;
using cs4227.UI;

namespace cs4227.Client
{
    internal class ContextObject
    {
        public string LoginContext(LoginMenuV2 reference)
        {
            return reference.UsernameTextBox();
        }

        public Order OrderContext()
        {
            var id = StaticAccessor.DB.GetNewestOrderId();
            return StaticAccessor.DB.GetOrder(id);
        }
    }
}