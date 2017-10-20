using Microsoft.VisualStudio.TestTools.UnitTesting;
using Graphs;
using System;

namespace GraphTests
{
    [TestClass]
    public class BFSTests
    {
        [TestMethod]
        public void BFSVertex_OnInstatiation_ShouldHaveStatusUndiscovered()
        {
            BFSVertex vertex = new BFSVertex();
            Assert.AreEqual(BFSVertex.EvalStatus.Undiscovered, vertex.Status);
        }

        [TestMethod]
        public void BFS_SeparationCount_GivenNullValues_ShouldThrowArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => BFS.SeparationCount(null, null));
            Assert.ThrowsException<ArgumentNullException>(() => BFS.SeparationCount(new BFSVertex(), null));
            Assert.ThrowsException<ArgumentNullException>(() => BFS.SeparationCount(null, new BFSVertex()));
        }

        [TestMethod]
        public void BFS_SeparationCount_GivenTwoNonConnectedVertices_ShouldReturnNegativeOne()
        {
            Assert.AreEqual(-1, BFS.SeparationCount(new BFSVertex(), new BFSVertex()));
        }

        [TestMethod]
        public void BFS_SeparationCount_GivenSameStartAndGoal_ShouldReturnZero()
        {
            BFSVertex firstAndLast = new BFSVertex();

            Assert.AreEqual(0, BFS.SeparationCount(firstAndLast, firstAndLast));
        }

        [TestMethod]
        public void BFS_SeparationCount_GivenTwoDirectlyConnectedVertices_ShouldReturnOne()
        {
            BFSVertex first = new BFSVertex();
            BFSVertex second = new BFSVertex();

            BFS.Connect(first, second);

            Assert.AreEqual(1, BFS.SeparationCount(first, second));
            Assert.AreEqual(1, BFS.SeparationCount(second, first));
        }
        
        [TestMethod]
        public void BFS_SeparationCount_GivenTwoConnectedVerticesSeparatedByOne_ShouldReturnTwo()
        {
            BFSVertex start = new BFSVertex();
            BFSVertex middle = new BFSVertex();
            BFSVertex goal = new BFSVertex();

            BFS.Connect(start, middle);
            BFS.Connect(middle, goal);

            Assert.AreEqual(2, BFS.SeparationCount(start, goal));
        }
    }
}
