using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace SortingTests
{
    [TestClass]
    public class MergesortTests
    {
        [TestMethod]
        public void Sort_GivenEmptyArray_ShouldLeaveTheArrayUnmodified()
        {
            GenericTests.Sort_GivenEmptyArray_ShouldLeaveTheArrayUnmodified(Mergesort.Sort);
        }

        [TestMethod]
        public void Sort_GivenSingleElementArray_ShouldLeaveTheArrayUnmodified()
        {
            GenericTests.Sort_GivenSingleElementArray_ShouldLeaveTheArrayUnmodified(Mergesort.Sort);
        }

        [TestMethod]
        public void Sort_GivenArrayWithUnsortedElements_ShouldSortElementsWithinTheArray()
        {
            GenericTests.Sort_GivenArrayWithUnsortedElements_ShouldSortElementsWithinTheArray(Mergesort.Sort);
        }
    }
}
