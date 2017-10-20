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

        public int SearchIndex { get; set; }
        
        public BFSVertex()
        {
            Status = EvalStatus.Undiscovered;
            SearchIndex = 0;
        }
    }
}
