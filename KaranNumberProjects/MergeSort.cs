using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class MergeSort
    {
        static int[] arrayToBeSorted = { 10, 14, 19, 26, 27, 31, 33, 35, 42, 44, 0 };
        
        public static void Merging(int low, int mid, int high)
        {
            int[] sortedArray = new int[arrayToBeSorted.Length];
            int l1, l2, i;
            for (l1 = low, l2 = mid + 1, i = low; l1 <= mid && l2 <= high; i++)
            {
                if(arrayToBeSorted[l1] <= arrayToBeSorted[l2])
                {
                    sortedArray[i] = arrayToBeSorted[l1++];
                }
                else
                {
                    sortedArray[i] = arrayToBeSorted[l2++];
                }
            }

            while(l1 <= mid)
            {
                sortedArray[i++] = arrayToBeSorted[l1++];
            }

            while(l2 <= high)
            {
                sortedArray[i++] = arrayToBeSorted[l2++];
            }

            for (i = low; i <= high; i++)
            {
                arrayToBeSorted[i] = sortedArray[i];
            }
        }

        public static void Sort(int low, int high)
        {
            int mid;

            if (low < high)
            {
                mid = (low + high) / 2;
                Sort(low, mid);
                Sort(mid+1, high);
                Merging(low, mid, high);
            }
            else
            {
                return;
            }
        }

        public static void ImplementMergeSort()
        {
            Console.WriteLine("Unsorted array of {0} length", arrayToBeSorted.Length);
            foreach (var item in arrayToBeSorted)
            {
                Console.Write(item + " ");
            }

            int max = arrayToBeSorted.Length - 1;

            Sort(0, max);

            Console.WriteLine("");
            Console.WriteLine("Sorted array of {0} length", arrayToBeSorted.Length);
            foreach (var item in arrayToBeSorted)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
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
