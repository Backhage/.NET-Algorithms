using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    public class GenericTests
    {
        internal static void Sort_GivenEmptyArray_ShouldLeaveTheArrayUnmodified(Action<Comparable[]> sortingMethod)
        {
            Comparable[] data = new Comparable[0];
            sortingMethod(data);

            Assert.AreEqual(0, data.Length);
        }

        internal static void Sort_GivenSingleElementArray_ShouldLeaveTheArrayUnmodified(Action<Comparable[]> sortingMethod)
        {
            Comparable[] data = new Comparable[1];
            const double expectedValue = 1.2;
            data[0] = new Comparable(expectedValue);

            sortingMethod(data);

            Assert.AreEqual(1, data.Length);
            Assert.AreEqual(expectedValue, data[0].Value);
        }

        internal static void Sort_GivenArrayWithUnsortedElements_ShouldSortElementsWithinTheArray(Action<Comparable[]> sortingMethod)
        {
            Comparable[] data = new Comparable[10000];
            Random rng = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = new Comparable(rng.NextDouble());
            }
            sortingMethod(data);
            for (int i = 1; i < data.Length; i++)
            {
                Assert.IsTrue(data[i-1].CompareTo(data[i]) <= 0);
            }
        }
    }
}