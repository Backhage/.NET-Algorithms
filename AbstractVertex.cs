using System;

namespace Graphs
{
    protected class AbstractVertex
    {
        public List<AbstractVertex> AdjecentVertices { get; }
        protected AbstractVertex()
        {
            AdjecentVertices = new List<AbstractVertex>();
        }
    }
}
