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
            string inputString = "Test this is a test of my thing";

            string[] inputStringArray = inputString.Split(' ');
            var count = inputStringArray.Select(x => x.Count());
            Console.Write(count);

            Console.ReadKey();
        }
    }
}
