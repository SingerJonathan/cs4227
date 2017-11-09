using System;
using System.Security.Cryptography;
using System.Text;

namespace cs4227.Meal
{
    class HashAdaptee : IHashAdaptee
    {
        public string HashString(string input)
        {
            string result = "";
            //Convert input into bytes
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            //Generate hash
            HashAlgorithm hashAlgorithm = new SHA256Managed();
            byte[] hash = hashAlgorithm.ComputeHash(inputBytes);
            //Convert each byte to 2 hexadecimal characters
            foreach (byte b in hash)
                result += $"{b:x2}";
            Console.WriteLine("Adaptee implementation called");
            return result;
        }
    }
}
