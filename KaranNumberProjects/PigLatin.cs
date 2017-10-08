using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class PigLatin
    {
        static char[] listOfVowels = "aeiou".ToArray();
        static char[] listOfConstanants = "bcdfghjklmnpqrstvwxyz".ToArray();
        public static void PigLatinImplementation()
        {
            string inputString = "";
            string reversedString = "";

            Console.WriteLine("Enter an string");
            inputString = Console.ReadLine();
            reversedString = ReturnPigLatin(inputString);

            Console.WriteLine("The input string is {0} and pig latin version is {1}", inputString, reversedString);
            Console.ReadKey();
        }

        private static string ReturnPigLatin(string inputString)
        {
            char[] inputCharArray = inputString.ToArray();
            //If >1 then first letter is a vowel
            int pos = Array.IndexOf(listOfVowels, inputCharArray[0]);
            if(pos > -1)
            {
                inputString += "way";
            }

            //If >1 then first letter is a vowel
            pos = Array.IndexOf(listOfConstanants, inputCharArray[0]);
            if (pos > -1)
            {
                inputString = inputString.Remove(0, 1);
                inputString += (inputCharArray[0] + "ay");
            }

            return inputString;
        }
    }
}
