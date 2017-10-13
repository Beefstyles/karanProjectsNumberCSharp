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
            int[] arrayToBeSorted = { 14, 33, 27, 35, 10, 12 ,256 ,45765, 56454,3253543,576,876,2, 53, 543, 1,2,3,4, 43435,867,769,456987,7845,654,56,435876,75675,789,567,756,876,78,978,56756,765,897,32,324,4354,65,796,-2 };
            string arrayToBeSortedStr = "";
            string sortedArray = "";
            int counter = 0;

            foreach (var item in arrayToBeSorted)
            {
                arrayToBeSortedStr += " " + item.ToString();
            }
            bool arraySwapped = true;

            Console.WriteLine("Sorting array {0}", arrayToBeSortedStr);

            for (int j = 0; j < arrayToBeSorted.Length - 1; j++)
            {
                counter++;
                arraySwapped = true;
                while (arraySwapped)
                {
                    for (int i = 0; i < arrayToBeSorted.Length - 1; i++)
                    {
                        //If point 0 is greater than 0+1 then switch the positions
                        if (arrayToBeSorted[i] > arrayToBeSorted[i + 1])
                        {
                            int temp = arrayToBeSorted[i];
                            arrayToBeSorted[i] = arrayToBeSorted[i + 1];
                            arrayToBeSorted[i + 1] = temp;
                            arraySwapped = true;
                            Console.WriteLine("Switching {0} and {1}", arrayToBeSorted[i], arrayToBeSorted[i + 1]);
                        }
                        //If point 0 is less than 0+1 so keep positions the same
                        else
                        {
                            arraySwapped = false;
                            Console.WriteLine("Not switching {0} and {1}", arrayToBeSorted[i], arrayToBeSorted[i + 1]);
                        }
                    }
                }
            }

            foreach (var item in arrayToBeSorted)
            {
                sortedArray += " " + item.ToString();
            }

            Console.WriteLine("Sorted array is now: {0}", sortedArray);
            Console.WriteLine("Sorted array in: {0} milliseconds and {1} iterations", stopwatch.Elapsed.Milliseconds, counter);
            Console.ReadKey();
        }
    }

}
