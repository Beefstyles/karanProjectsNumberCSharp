using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class WordFunnel
    {
        public static void WordFunnelCheck()
        {
            IsWordFunnel("leave", "eave");
            IsWordFunnel("reset", "rest");
            IsWordFunnel("dragoon", "dragon");
            IsWordFunnel("eave", "leave");
            IsWordFunnel("sleet", "lets");
            IsWordFunnel("skiff", "ski");
            Console.ReadKey();
        }
        public static bool IsWordFunnel(string firstWord, string secondWord)
        {
            Console.Write("Checking {0} to see if you can remove one letter and make {1} => ", firstWord, secondWord);
            char[] firstWordArray = firstWord.ToCharArray();
            List<char> tempArray = new List<char>();
            int count = 0;
            while(count <= firstWordArray.Length)
            {
                tempArray.Clear();
                for (int i = 0; i < firstWordArray.Length; i++)
                {
                    if(i != count)
                    {
                        tempArray.Add(firstWordArray[i]);
                    }
                }
                StringBuilder builder = new StringBuilder();
                tempArray.ForEach(x => builder.Append(x));

                string testWord = builder.ToString();
                if(testWord == secondWord)
                {
                    Console.WriteLine("True");
                    return true;
                }
                count++;
            }
            Console.WriteLine("False");
            return false;
        }


    }
}
