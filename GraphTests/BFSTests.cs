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
        public void BFS_SeparationCount_GivenTwoDirectlyConnectedVertices_ShouldReturnZero()
        {
            BFSVertex first = new BFSVertex();
            BFSVertex second = new BFSVertex();
            first.AddAdjecentVertex(second);
            second.AddAdjecentVertex(first);

            Assert.AreEqual(0, BFS.SeparationCount(first, second));
            Assert.AreEqual(0, BFS.SeparationCount(second, first));
        }
        
        [TestMethod]
        public void BFS_SeparationCount_GivenTwoConnectedVerticesSeparatedByOne_ShouldReturnOne()
        {
            BFSVertex start = new BFSVertex();
            BFSVertex middle = new BFSVertex();
            BFSVertex goal = new BFSVertex();

            start.AddAdjecentVertex(middle);
            middle.AddAdjecentVertex(start);
            middle.AddAdjecentVertex(goal);
            goal.AddAdjecentVertex(middle);

            Assert.AreEqual(1, BFS.SeparationCount(start, goal));
        }
    }
}
