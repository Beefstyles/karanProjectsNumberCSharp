using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class PalindromCheck
    {

        public static void CheckIfPalindrome()
        {
            bool isStringPalindrome;
            string inputString = "";
            Console.WriteLine("Enter an string");
            inputString = Console.ReadLine().Trim();
            isStringPalindrome = isPalindrome(inputString);
            if (isStringPalindrome)
            {
                Console.WriteLine("{0} is a palindrome", inputString);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome", inputString);
            }

            Console.ReadKey();
        }

        private static bool isPalindrome(string inputString)
        {
            char[] stringArray = inputString.Trim().ToCharArray();
            string reversedString = "";
            Array.Reverse(stringArray);
            foreach (var item in stringArray)
            {
                reversedString += item.ToString();
            }

            if(reversedString == inputString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
