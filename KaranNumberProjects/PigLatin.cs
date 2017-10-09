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
        static string[] listOfConstonantClusters = { "ch", "sh", "sm", "th", "st", "sc", "scr" };
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


            int posCluster = Array.IndexOf(listOfConstonantClusters, (inputCharArray[0].ToString() + inputCharArray[1].ToString()+ inputCharArray[2].ToString()));

            //If >1 then first three letters make up consonant cluster
            if (posCluster > -1)
            {
                inputString = inputString.Remove(0, 3);
                inputString += (inputCharArray[0].ToString() + inputCharArray[1].ToString() + inputCharArray[2].ToString() + "ay");
                Console.WriteLine("Using three letter consonant cluster rule");
                return inputString;
            }

            posCluster = Array.IndexOf(listOfConstonantClusters, (inputCharArray[0].ToString() + inputCharArray[1].ToString()));

            //If >1 then first two letters make up consonant cluster
            if (posCluster > -1)
            {
                inputString = inputString.Remove(0, 2);
                inputString += (inputCharArray[0].ToString() + inputCharArray[1].ToString() + "ay");
                Console.WriteLine("Using two letter consonant cluster rule");
                return inputString;
            }
            //If >1 then first letter is a vowel
            int posVowel = Array.IndexOf(listOfVowels, inputCharArray[0]);

            if(posVowel > -1)
            {
                inputString += "way";
                Console.WriteLine("Using vowel rule");
                return inputString;
            }

            //If >1 then first letter is a consonant
            int posConst = Array.IndexOf(listOfConstanants, inputCharArray[0]);
            if (posConst > -1)
            {
                inputString = inputString.Remove(0, 1);
                inputString += (inputCharArray[0] + "ay");
                Console.WriteLine("Using consonant rule");
                return inputString;
            }

            return inputString;
        }
    }
}
