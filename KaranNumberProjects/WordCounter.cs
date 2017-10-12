using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class WordCounter
    {
        public static void WordCounterImplementation()
        {
            string inputString = "Test this is a test of my thing.";

            //Convert inputstring to array split up by spaces - removes punctuation
            string[] inputStringArray = inputString.ToLower().Replace('.',' ').Replace(',', ' ').Replace('!', ' ').Replace('?', ' ').Split(' ');

            //Gets the distinct values of the input string array
            var inputStringArrayWithDistinctElements = inputStringArray.Distinct().ToArray();

            //Creates a dictionary to hold the word counter
            Dictionary<string, int> wordCount = new Dictionary<string, int>();


            //Initialises the dictionary with unique words at count 0
            foreach (var item in inputStringArrayWithDistinctElements)
            {
                if(item != "")
                {
                    wordCount.Add(item, 0);
                }
            }

            //Checks against the inputstring array with the unique dictionary and increments the value everytime the word is used
            foreach (var item in inputStringArray)
            {
                if (item != "")
                {
                    wordCount[item]++;
                }
            }


            //Iterates through the dictionary to print out the count for each word
            foreach (var item in wordCount)
            {
                Console.WriteLine("{0} is in the string {1} times", item.Key, item.Value);
            }


            Console.ReadKey();
        }
    }
}
