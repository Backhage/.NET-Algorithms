using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    [TestClass]
    public class InsertionsortTests
    {
        [TestMethod]
        public void Sort_GivenEmptyArray_ShouldLeaveTheArrayUnmodified()
        {
            GenericTests.Sort_GivenEmptyArray_ShouldLeaveTheArrayUnmodified(Insertionsort.Sort);
        }

        [TestMethod]
        public void Sort_GivenSingleElementArray_ShouldLeaveTheArrayUnmodified()
        {
            GenericTests.Sort_GivenSingleElementArray_ShouldLeaveTheArrayUnmodified(Insertionsort.Sort);
        }

        [TestMethod]
        public void Sort_GivenArrayWithUnsortedElements_ShouldSortElementsWithinTheArray()
        {
            GenericTests.Sort_GivenArrayWithUnsortedElements_ShouldSortElementsWithinTheArray(Insertionsort.Sort);
        }
    }
}
