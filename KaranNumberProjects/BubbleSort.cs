using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class BubbleSort
    {
        public static void BubbleSortImplementation()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] arrayToBeSorted = { 14, 33, 27, 35, 10 };
            string arrayToBeSortedStr = "";
            string sortedArray = "";

            foreach (var item in arrayToBeSorted)
            {
                arrayToBeSortedStr += " " + item.ToString();
            }
            bool arrayIsSorted = false;

            Console.WriteLine("Sorting array {0}", arrayToBeSortedStr);

            while (!arrayIsSorted)
            {
                for (int i = 0; i < arrayToBeSorted.Length - 1; i++)
                {
                    Console.WriteLine("Comparing {0} and {1}", arrayToBeSorted[i], arrayToBeSorted[i + 1]);
                    if (arrayToBeSorted[i] > arrayToBeSorted[i + 1])
                    {
                        arrayToBeSorted[i] = arrayToBeSorted[i + 1];
                        arrayIsSorted = false;
                    }
                    else
                    {
                        arrayIsSorted = true;
                    }
                }
            }

            foreach (var item in arrayToBeSorted)
            {
                sortedArray += " " + item.ToString();
            }

            Console.WriteLine("Sorted array {0}", sortedArray);
            Console.WriteLine("Sorted array in: {0}", stopwatch.Elapsed);
            Console.ReadKey();
        }
    }
}
