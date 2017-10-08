using System;

namespace Sorting
{
    public class Heapsort
    {
        /* The heap sort algorithm orders the elements in the array as a max-heap.
           From the heap it then takes the largest element and places it at the last position.
           The element that was previously last is put in the first position and then sifted down
           in the heap, restoring the heap order.

           Now the new largest element(not including the one already put last) is swapped with
           the second last element, inserting the second largest element just before the largest element
           in the array.
           
           The procedure is then repeated until the complete array has been sorted.
         */
        public static void Sort<T>(T[] data) where T : IComparable
        {
            if (data.Length <= 1)
            {
                return;
            }

            Heapify(data);
            int end = data.Length - 1;
            while (end > 0)
            {
                Swap(data, end, 0);
                end--;
                SiftDown(data, 0, end);
            }
        }

        /* A binary heap is a data structure that takes the form of a binary tree.
           In a max - heap the key stored in each node is larger, or equal to, the
           key stored in it's two children.

           The heap is created by assuming that the current data is a max - heap that is
           "broken", i.e.there might be nodes with a key smaller than any of it's children.
           The order in restored by sifting down the nodes, starting at the last leaf's parent
           and then moving up the tree towards the root.
        */
        private static void Heapify<T>(T[] data) where T : IComparable
        {
            int start = ParentIndex(data.Length - 1);
            while (start >= 0)
            {
                SiftDown(data, start, data.Length - 1);
                start--;
            }
        }

        private static int ParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        private static void SiftDown<T>(T[] data, int start, int end) where T : IComparable
        {
            int root = start;
            while (LeftChildIndex(root) <= end)
            {
                int child = LeftChildIndex(root);
                int swap = root;
                if (data[swap].CompareTo(data[child]) < 0)
                {
                    swap = child;
                }
                if (child+1 <= end && data[swap].CompareTo(data[child+1]) < 0)
                {
                    swap = child + 1;
                }
                if (swap == root)
                {
                    return;
                }
                Swap(data, root, swap);
                root = swap;
            }
        }

        private static int LeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        private static void Swap<T>(T[] data, int i, int j)
        {
            T tmp = data[i];
            data[i] = data[j];
            data[j] = tmp;
        }
    }
}