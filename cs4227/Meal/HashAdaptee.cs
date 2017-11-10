using System;
using System.Security.Cryptography;
using System.Text;

namespace cs4227.Meal
{
    internal class HashAdaptee : IHashAdaptee
    {
        public string HashString(string input)
        {
            var result = "";
            //Convert input into bytes
            var inputBytes = Encoding.UTF8.GetBytes(input);
            //Generate hash
            HashAlgorithm hashAlgorithm = new SHA256Managed();
            var hash = hashAlgorithm.ComputeHash(inputBytes);
            //Convert each byte to 2 hexadecimal characters
            foreach (var b in hash)
                result += $"{b:x2}";
            Console.WriteLine(@"Adaptee implementation called");
            return result;
        }
    }
}