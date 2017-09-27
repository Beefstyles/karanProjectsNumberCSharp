using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class MergeSort
    {
        public static void MergeSortImplementation()
        {
            List<int> arrayToBeSorted = new List<int> { 14, 33, 27, 10, 35, 19, 42, 44};
            Console.WriteLine("Unsorted array of {0} count", arrayToBeSorted.Count);
            foreach (var item in arrayToBeSorted)
            {
                Console.Write(item + " ");
            }

            List<int> sortedArray = new List<int>();
            sortedArray = MergeSortArray(arrayToBeSorted);

            Console.WriteLine("");
            Console.WriteLine("Sorted array of {0} count", sortedArray.Count);
            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();

        }

        private static List<int> MergeSortArray(List<int> arrayToBeSorted)
        {
            if (arrayToBeSorted.Count > 1)
            {
                Console.WriteLine(arrayToBeSorted.Count);


                List<int> l1 = new List<int>();
                List<int> l2 = new List<int>();


                for (int i = 1; i <= (arrayToBeSorted.Count / 2); i++)
                {
                    l1.Add(arrayToBeSorted[i]);
                }

                for (int i = (arrayToBeSorted.Count / 2) + 1; i < arrayToBeSorted.Count; i++)
                {
                    l2.Add(arrayToBeSorted[i]);
                }


                l1 = MergeSortArray(l1);
                l2 = MergeSortArray(l2);

                return MergeArray(l1, l2);
            }

            else
            {
                Console.WriteLine("Should return");
                return arrayToBeSorted;
            }
        }

        private static List<int> MergeArray(List<int> array1, List<int> array2)
        {
            List<int> array3 = new List<int>();
            Console.WriteLine("A1 count {0} and A2 count {1}", array1.Count, array2.Count);

            while (array1.Count > 0 && array2.Count > 0)
            {
                if(array1[0] > array2[0])
                {
                    array3.Add(array2[0]);
                    array2.RemoveAt(0);
                }
                else
                {
                    array3.Add(array1[0]);
                    array1.RemoveAt(0);
                }
            }

            while (array1.Count > 0)
            {
                array3.Add(array1[0]);
                array1.RemoveAt(0);
            }

            while (array2.Count > 0)
            {
                array3.Add(array2[0]);
                array2.RemoveAt(0);
            }
            return array3;
        }
    }
}
