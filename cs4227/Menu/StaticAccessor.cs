using System;
using System.Text;
using cs4227.Meal;

namespace cs4227.Menu
{
    class StaticAccessor
    {
        private static Invoker invoker;
        private static double[] discounts = { 0, 1, 1.3, 1.6 };
        private static string salt = "936DefinitelyNotACulinaryIngredient428";

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
            if (result.Substring(0, 1).Equals("."))
                result = "0" + result;
            return result;
        }

        public static string HashString(string input)
        {
            string result = "";
            //Convert input and salt into bytes
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            //Add salt to input
            byte[] mergedBytes = new byte[inputBytes.Length + saltBytes.Length];
            Buffer.BlockCopy(inputBytes, 0, mergedBytes, 0, inputBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, mergedBytes, inputBytes.Length, saltBytes.Length);
            //Generate hash
            System.Security.Cryptography.HashAlgorithm hashAlgorithm = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashAlgorithm.ComputeHash(mergedBytes);
            //Add salt to the hash
            byte[] hashPlusSalt = new byte[hash.Length + saltBytes.Length];
            Buffer.BlockCopy(hash, 0, hashPlusSalt, 0, hash.Length);
            Buffer.BlockCopy(saltBytes, 0, hashPlusSalt, hash.Length, saltBytes.Length);
            //Convert each byte to 2 hexadecimal characters
            foreach (byte b in hashPlusSalt)
                result += $"{b:x2}";
            return result;
        }
    }
}
