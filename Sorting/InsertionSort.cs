using System;

namespace Sorting
{
    public class Insertionsort
    {
        public static void Sort<T>(T[] data) where T : IComparable, IEquatable<IComparable>
        {
            if (data == null || data.Length == 0)
            {
                return;
            }

            for (int i = 1; i < data.Length; i++)
            {
                int j = i;
                while (j > 0 && data[j-1].CompareTo(data[j]) > 0)
                {
                    Swap(data, j - 1, j);
                    j--;
                }
            }
        }

        private static void Swap<T>(T[] data, int i, int j)
        {
            T tmp = data[i];
            data[i] = data[j];
            data[j] = tmp;
        }
    }
}