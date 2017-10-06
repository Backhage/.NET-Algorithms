using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace SortingTests
{
    [TestClass]
    public class HeapsortTests
    {
        [TestMethod]
        public void Sort_GivenEmptyArray_ShouldLeaveTheArrayUnmodified()
        {
            GenericTests.Sort_GivenEmptyArray_ShouldLeaveTheArrayUnmodified(Heapsort.Sort);
        }

        [TestMethod]
        public void Sort_GivenSingleElementArray_ShouldLeaveTheArrayUnmodified()
        {
            GenericTests.Sort_GivenSingleElementArray_ShouldLeaveTheArrayUnmodified(Heapsort.Sort);
        }

        [TestMethod]
        public void Sort_GivenArrayWithUnsortedElements_ShouldSortElementsWithinTheArray()
        {
            GenericTests.Sort_GivenArrayWithUnsortedElements_ShouldSortElementsWithinTheArray(Heapsort.Sort);
        }
    }
}