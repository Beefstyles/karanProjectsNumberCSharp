using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class VowelCounter
    {
        static char[] listOfVowels = "aeiou".ToArray();
        

        public static void VowelCounterImplementation()
        {
            Dictionary<char, int> numberOfVowels = new Dictionary<char, int>();
            for (int i = 0; i < listOfVowels.Length; i++)
            {
                numberOfVowels.Add(listOfVowels[i], 0);
            }

            string inputString = "";
            int vowelCount;
            Console.WriteLine("Enter an string");
            inputString = Console.ReadLine();
            vowelCount = ReturnNumberOfVowels();

            Console.WriteLine("The input string is {0} and pig latin version is {1}", inputString, reversedString);
            Console.ReadKey();
        }

        private static int ReturnNumberOfVowels(string inputString, char currentVowel)
        {

        }
    }
}
