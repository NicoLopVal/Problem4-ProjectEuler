using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 0;

            for(int i = 999; i >= 2; i--)
            {
                for (int j = 999; j >= 2; j--)
                {
                    int productValue = i * j;
                    if (IsPalindromic(productValue) && productValue > maxValue)
                        maxValue = productValue;
                }
            }

            Console.WriteLine("The largest palindrome made from the product of two 3-digit numbers is: " + maxValue);
        }

        static bool IsPalindromic(int product)
        {
            bool isPal = false;
            char[] digits = product.ToString().ToCharArray();
            string backwardsString = "";

            for(int i = digits.Length - 1; i >= 0; i--)
            {
                backwardsString = backwardsString + digits[i];
            }
            if (backwardsString == product.ToString())
                isPal = true;

            return isPal;
        }
    }
}
