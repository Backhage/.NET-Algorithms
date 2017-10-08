using System;

namespace Sorting
{
    public class Mergesort
    {
        /* Mergesort is a stable sorting algorithm that runs in NlogN time complexity and has N space complexity. 
           It conceptially works by dividing the array of N elements into N subarrays (each containing one element)
           and then repeatedly merge subarrays together until only one array remains. 
        */
        public static void Sort<T>(T[] data) where T : IComparable
        {
            T[] workarray = new T[data.Length];
            Array.Copy(data, workarray, data.Length);
            SplitMerge(workarray, 0, data.Length, data);
        }

        private static void SplitMerge<T>(T[] a, int begin, int end, T[] b) where T : IComparable
        {
            // An array of size 1 is considered sorted, hence size 1 is the base case for the recursion.
            if ((end - begin) < 2)
            {
                return;
            }
            // Split the array into two parts. Begin to middle and middle to end.
            // Do this recursively until the base case is reached.
            int middle = begin + ((end - begin) / 2);
            SplitMerge(b, begin, middle, a);
            SplitMerge(b, middle, end, a);
            // The merge concludes the sorting algorithm.
            Merge(a, begin, middle, end, b);
        }

        private static void Merge<T>(T[] a, int begin, int middle, int end, T[] b) where T : IComparable
        {
            int i = begin;
            int j = middle;

            for (int k = begin; k < end; k++)
            {
                if (i < middle && (j >= end || a[i].CompareTo(a[j]) <= 0))
                {
                    b[k] = a[i];
                    i++;
                }
                else
                {
                    b[k] = a[j];
                    j++;
                }
            }
        }
    }
}
