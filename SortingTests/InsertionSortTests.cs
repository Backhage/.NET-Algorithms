using Sorting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void Sort_GivenEmptyArray_ShouldReturnEmptyArray()
        {
            Comparable[] data = new Comparable[0];
            InsertionSort.Sort(data);
            Assert.AreEqual(0, data.Length);
        }

        [TestMethod]
        public void Sort_GivenSingleElementArray_ShouldReturnArrayWithSameElement()
        {
            Comparable[] data = new Comparable[1];
            const double expectedValue = 1.2;
            data[0] = new Comparable(expectedValue);

            InsertionSort.Sort(data);

            Assert.AreEqual(1, data.Length);
            Assert.AreEqual(expectedValue, data[0].Value);
        }

        [TestMethod]
        public void Sort_GivenArrayWithUnsortedElements_ShouldReturnArrayWithElementsSorted()
        {
            Comparable[] data = new Comparable[100];
            Random rng = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = new Comparable(rng.NextDouble());
            }
            InsertionSort.Sort(data);
            for (int i = 1; i < data.Length; i++)
            {
                Assert.IsTrue(data[i-1].CompareTo(data[i]) <= 0);
            }
        }

        private class Comparable : IComparable, IEquatable<IComparable>
        {
            public double Value { get; }

            public Comparable(double value)
            {
                Value = value;
            }

            public int CompareTo(object obj)
            {
                if (obj == null)
                {
                    return 1;
                }
                Comparable other = obj as Comparable;
                if (other == null)
                {
                    throw new ArgumentException("Invalid parameter type");
                }
                return Value.CompareTo(other.Value);
            }

            public bool Equals(IComparable other)
            {
                if (other == null)
                {
                    return false;
                }
                var otherComparable = other as Comparable;
                if (otherComparable == null)
                {
                    return false;
                }
                return Value.Equals(otherComparable.Value);
            }
        }
    }
}
