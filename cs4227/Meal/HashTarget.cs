using System;

namespace cs4227.Meal
{
    public class HashTarget : IHashTarget
    {
        public string ReverseString(string input)
        {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(@"Target implementation called");
            return new string(charArray);
        }
    }
}