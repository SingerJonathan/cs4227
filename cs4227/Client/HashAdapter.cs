using System;
using System.Security.Cryptography;
using System.Text;
using cs4227.Meal;

namespace cs4227.Client
{
    internal class HashAdapter : HashAdaptee
    {
        private static readonly string salt = "936DefinitelyNotACulinaryIngredient428";
        public Func<string, string> RequestDelegate;

        // Set the delegate to the new standard
        // Adapter-Adaptee
        public HashAdapter(IHashAdaptee adaptee)
        {
            RequestDelegate = delegate(string input)
            {
                var result = "";
                //Convert input and salt into bytes
                var inputBytes = Encoding.UTF8.GetBytes(input);
                var saltBytes = Encoding.UTF8.GetBytes(salt);
                //Add salt to input
                var mergedBytes = new byte[inputBytes.Length + saltBytes.Length];
                Buffer.BlockCopy(inputBytes, 0, mergedBytes, 0, inputBytes.Length);
                Buffer.BlockCopy(saltBytes, 0, mergedBytes, inputBytes.Length, saltBytes.Length);
                //Generate hash
                HashAlgorithm hashAlgorithm = new SHA256Managed();
                var hash = hashAlgorithm.ComputeHash(mergedBytes);
                //Add salt to the hash
                var hashPlusSalt = new byte[hash.Length + saltBytes.Length];
                Buffer.BlockCopy(hash, 0, hashPlusSalt, 0, hash.Length);
                Buffer.BlockCopy(saltBytes, 0, hashPlusSalt, hash.Length, saltBytes.Length);
                //Convert each byte to 2 hexadecimal characters
                foreach (var b in hashPlusSalt)
                    result += $"{b:x2}";
                Console.WriteLine(@"Adapter implementation called");
                return result;
            };
        }

        // Set the delegate to the existing standard
        // Adapter-Target
        public HashAdapter(IHashTarget target)
        {
            RequestDelegate = target.ReverseString;
        }

        // Set the delegate to any standard
        // Adapter Target/Any_Adaptee
        public HashAdapter(Func<string, string> r)
        {
            RequestDelegate = r;
        }
    }
}