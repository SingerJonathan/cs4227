using System;
using cs4227.Database;
using cs4227.Meal;

namespace cs4227.UI
{
    internal class StaticAccessor
    {
        public static IDatabaseHandler DB { get; set; } = new DatabaseHandler();
        public static string AppName { get; set; }

        internal static Invoker Invoker { get; set; }

        public static double[] Discounts { get; set; } = {0, 1, 1.3, 1.6};

        public static string DoubleToMoneyString(double value)
        {
            var result = "" + value;
            if (result.Equals("0"))
                result = "0.00";
            else
                result = string.Format("{0:#.00}", Convert.ToDecimal(result));
            if (result.Substring(0, 1).Equals("."))
                result = "0" + result;
            return result;
        }

        public static string HashString(string input)
        {
            var adapter = new HashAdapter.HashAdapter(new HashAdaptee());
            var result = adapter.RequestDelegate(input);
            if (!result.Equals(""))
                return result;
            var adapter2 = new HashAdapter.HashAdapter(new HashTarget());
            return adapter2.RequestDelegate(input);
        }
    }
}