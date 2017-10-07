using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class ReverseString
    {
        public static void ReverseStringImplementation()
        {
            string inputString = "";
            string reversedString = "";

            Console.WriteLine("Enter an string");
            inputString = Console.ReadLine();
            reversedString = ReturnReversedString(inputString);

            Console.WriteLine("The input string is {0} and reversed is {1}", inputString, reversedString);
            Console.ReadKey();
        }

        private static string ReturnReversedString(string currentString)
        {
            char[] stringArray = currentString.ToCharArray();
            string reversedString = "";
            Array.Reverse(stringArray);
            foreach (var item in stringArray)
            {
                reversedString += item.ToString();
            }
            return reversedString;
        }
    }
}
