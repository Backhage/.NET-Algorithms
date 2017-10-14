using System.Collections.Generic;

namespace Graphs
{
    public abstract class AbstractVertex
    {
        public List<AbstractVertex> AdjacencyList { get; }
        protected AbstractVertex()
        {
            AdjacencyList = new List<AbstractVertex>();
        }

        public void AddAdjecentVertex(AbstractVertex adjecentVertex)
        {
            AdjacencyList.Add(adjecentVertex);
        }
    }
}
