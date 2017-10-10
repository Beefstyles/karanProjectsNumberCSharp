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

            string inputString = "";
            Console.WriteLine("Enter an string");
            inputString = Console.ReadLine();

            //Add vowels to dict
            for (int i = 0; i < listOfVowels.Length; i++)
            {
                numberOfVowels.Add(listOfVowels[i], 0);
            }

            for (int i = 0; i < listOfVowels.Length; i++)
            {
                numberOfVowels[listOfVowels[i]] = ReturnNumberOfVowels(inputString, listOfVowels[i]);
            }

            Console.WriteLine("The input string is {0}:", inputString);

            Console.WriteLine("Letter: a,  Count: {0}", numberOfVowels['a']);
            Console.WriteLine("Letter: e,  Count: {0}", numberOfVowels['e']);
            Console.WriteLine("Letter: i,  Count: {0}", numberOfVowels['i']);
            Console.WriteLine("Letter: o,  Count: {0}", numberOfVowels['o']);
            Console.WriteLine("Letter: u,  Count: {0}", numberOfVowels['u']);
            Console.ReadKey();
        }

        private static int ReturnNumberOfVowels(string inputString, char currentVowel)
        {
            int count;
            return count = inputString.Count(x => x == currentVowel);
        }
    }
}
