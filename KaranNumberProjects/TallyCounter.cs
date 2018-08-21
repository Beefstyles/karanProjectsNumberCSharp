using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class TallyCounter
    {
        public static void ReturnTally()
        {
            TallyString("dbbaCEDbdAacCEAadcBabbbbDcEEEbbcdaBBCCDDee");
            Console.ReadKey();
        }

        private static void TallyString(string tallyString)
        {
            Dictionary<char, int> tallyDict = new Dictionary<char, int>
            {
                { 'a', 0 },
                { 'b', 0 },
                { 'c', 0 },
                { 'd', 0 },
                { 'e', 0 }
            };

            char[] tallyCharArray = tallyString.ToCharArray();

            foreach (char tally in tallyCharArray)
            {
                if (char.IsUpper(tally))
                {
                    tallyDict[char.ToLower(tally)]--;
                }
                else
                {
                    tallyDict[tally]++;
                }
            }
            var tallyList = from entry in tallyDict orderby entry.Value descending select entry;
            int count = 0;
            foreach (var item in tallyList)
            {
                count++;
                if (count != tallyList.Count())
                {
                    Console.Write("{0}:{1}, ", item.Key, item.Value);
                }
                else
                {
                    Console.Write("{0}:{1}", item.Key, item.Value);
                }
                

            }
        }
    }
}
