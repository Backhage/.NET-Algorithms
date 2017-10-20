using System;
using System.Collections.Generic;

namespace Graphs
{
    public class BFS
    {
        public static void Connect(BFSVertex v1, BFSVertex v2)
        {
            if (!v1.AdjacencyList.Contains(v2))
            {
                v1.AddAdjecentVertex(v2);
            }
            if (!v2.AdjacencyList.Contains(v1))
            {
                v2.AddAdjecentVertex(v1);
            }
        }

        /**
         * Counts the number of edges separating two vertices and returns the count. Two directly connected vertices are
         * separated by one edge and has a separation count of exactly one.
         * If no connection between the vertices exists -1 is returned.
         * 
         * NOTE: This modifies the state of the vertices.
         */ 
        public static int SeparationCount(BFSVertex start, BFSVertex goal) 
        {
            if (start == null || goal == null)
            {
                throw new ArgumentNullException("Arguments can not be null");
            }

            if (start.Equals(goal))
            {
                return 0;
            }

            Queue<BFSVertex> searchQueue = new Queue<BFSVertex>();
            searchQueue.Enqueue(start);

            while (searchQueue.Count > 0)
            {
                BFSVertex current = searchQueue.Dequeue();
                current.Status = BFSVertex.EvalStatus.Visited;

                foreach (BFSVertex adjacent in current.AdjacencyList)
                {
                    if (adjacent.Equals(goal))
                    {
                        return current.SearchIndex + 1;
                    }
                    if (adjacent.Status == BFSVertex.EvalStatus.Undiscovered)
                    {
                        adjacent.Status = BFSVertex.EvalStatus.Discovered;
                        adjacent.SearchIndex = current.SearchIndex + 1;
                        searchQueue.Enqueue(adjacent);
                    }
                }
            }

            return -1;
        }
    }
}
