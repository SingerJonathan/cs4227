using System;
using cs4227.Meal;

namespace cs4227.Menu
{
    class StaticAccessor
    {
        public static Invoker Invoker;

        public static void Main()
        {
            Invoker = new Invoker();

            LoginMenuV2 LG = new LoginMenuV2();
            LG.ShowDialog();
        }

        public static string DoubleToMoneyString(double value)
        {
            string result = "" + value;
            if (result.Equals("0"))
                result = "0.00";
            else
                result = string.Format("{0:#.00}", Convert.ToDecimal(result));
            return result;
        }
    }
}
