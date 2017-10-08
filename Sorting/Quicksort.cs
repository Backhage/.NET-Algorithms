using System;

namespace Sorting
{
    public class Quicksort
    {
        public static void Sort<T>(T[] data) where T : IComparable
        {
            QuickSort(data, 0, data.Length - 1);
        }

        private static void QuickSort<T>(T[] data, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                int pivot = Partition(data, low, high);
                QuickSort(data, low, pivot);
                QuickSort(data, pivot + 1, high);
            }
        }

        private static int Partition<T>(T[] data, int low, int high) where T : IComparable
        {
            T pivot = data[low];
            int i = low - 1;
            int j = high + 1;
            while (true)
            {
                do
                {
                    i++;
                } while (data[i].CompareTo(pivot) < 0);

                do
                {
                    j--;
                } while (data[j].CompareTo(pivot) > 0);

                if (i >= j)
                {
                    return j;
                }

                T tmp = data[i];
                data[i] = data[j];
                data[j] = tmp;
            }
        }
    }
}
