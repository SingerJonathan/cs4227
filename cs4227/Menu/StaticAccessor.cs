using System;
using cs4227.Meal;

namespace cs4227.Menu
{
    class StaticAccessor
    {
        private static Invoker invoker;
        private static double[] discounts = { 0, 1, 1.3, 1.6 };

        internal static Invoker Invoker { get => invoker; set => invoker = value; }
        public static double[] Discounts { get => discounts; set => discounts = value; }

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
