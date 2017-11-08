using System;
using cs4227.Meal;

namespace cs4227.UI
{
    class StaticAccessor
    {
        private static string _appName;
        private static Invoker invoker;
        private static double[] discounts = { 0, 1, 1.3, 1.6 };

        public static string AppName { get => _appName; set => _appName = value; }
        internal static Invoker Invoker { get => invoker; set => invoker = value; }
        public static double[] Discounts { get => discounts; set => discounts = value; }

        public static string DoubleToMoneyString(double value)
        {
            string result = "" + value;
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
            HashAdapter.HashAdapter adapter = new HashAdapter.HashAdapter(new HashAdaptee());
            string result = adapter.RequestDelegate(input);
            if (!result.Equals(""))
                return result;
            HashAdapter.HashAdapter adapter2 = new HashAdapter.HashAdapter(new HashTarget());
            return adapter2.RequestDelegate(input);
        }
    }
}
