using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace SortingTests
{
    [TestClass]
    public class QuicksortTests
    {
        [TestMethod]
        public void Sort_GivenEmptyArray_ShouldLeaveTheArrayUnmodified()
        {
            GenericTests.Sort_GivenEmptyArray_ShouldLeaveTheArrayUnmodified(Quicksort.Sort);
        }

        [TestMethod]
        public void Sort_GivenSingleElementArray_ShouldLeaveTheArrayUnmodified()
        {
            GenericTests.Sort_GivenSingleElementArray_ShouldLeaveTheArrayUnmodified(Quicksort.Sort);
        }

        [TestMethod]
        public void Sort_GivenArrayWithUnsortedElements_ShouldSortElementsWithinTheArray()
        {
            GenericTests.Sort_GivenArrayWithUnsortedElements_ShouldSortElementsWithinTheArray(Quicksort.Sort);
        }
    }
}
