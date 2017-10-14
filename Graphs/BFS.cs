using System;
using System.Collections.Generic;

namespace Graphs
{
    public class BFS
    {
        public static int SeparationCount(BFSVertex start, BFSVertex goal) 
        {
            if (start == null || goal == null)
            {
                throw new ArgumentNullException("Arguments can not be null");
            }
            // TODO: Need a way to keep track of distance (add to vertex or backtrack?)
            int distance = 1;
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
                        return distance;
                    }
                    if (adjacent.Status == BFSVertex.EvalStatus.Undiscovered)
                    {
                        adjacent.Status = BFSVertex.EvalStatus.Discovered;
                        searchQueue.Enqueue(adjacent);
                    }
                }
            }

            return -1;
        }
    }
}
