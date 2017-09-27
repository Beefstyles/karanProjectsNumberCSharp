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

            Console.WriteLine("Unsorted");
            foreach (var item in arrayToBeSorted)
            {
                Console.Write(item + " ");
            }

            List<int> sortedArray = new List<int>();

            sortedArray = MergeSortArray(arrayToBeSorted);

            Console.WriteLine("Sorted");
            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }

        }

        private static List<int> MergeSortArray(List<int> arrayToBeSorted)
        {
            Console.WriteLine(arrayToBeSorted.Count);
            if (arrayToBeSorted.Count == 1)
            {
                return arrayToBeSorted;
            }

            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();

            for (int i = 0; i <= arrayToBeSorted.Count / 2; i++)
            {
                l1.Add(arrayToBeSorted[i]);
            }
            for (int i = (arrayToBeSorted.Count / 2)+1; i < arrayToBeSorted.Count; i++)
            {
                l2.Add(arrayToBeSorted[i]);
            }


            l1 = MergeSortArray(l1);
            l2 = MergeSortArray(l2);

            return MergeArray(l1, l2);
        }

        private static List<int> MergeArray(List<int> array1, List<int> array2)
        {
            List<int> array3 = new List<int>();

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
