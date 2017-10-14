using System;

namespace Graphs
{
    public class BFSVertex : AbstractVertex
    {
        public enum EvalStatus
        {
            Undiscovered,
            Discovered,
            Visited
        }

        public EvalStatus Status { get; set; }

        public BFSVertex()
        {
        }
    }
}
