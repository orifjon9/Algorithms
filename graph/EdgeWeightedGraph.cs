using System.Collections.Generic;

namespace Graph
{
    public class EdgeWeightedGraph
    {
        private readonly int _vertices;
        private List<Edge>[] _adjs;
        private int _edgesCount = 0;

        public EdgeWeightedGraph(int vertices)
        {
            _vertices = vertices;
            _adjs = new List<Edge>[vertices];
            
            for (int i = 0; i < vertices; i++)
            {
                _adjs[i] = new List<Edge>();
            }
        }

        public void Add(Edge edge)
        {
            var v = edge.Either();
            var w = edge.Other(v);

            _adjs[v].Add(edge);
            _adjs[w].Add(edge);

            _edgesCount++;
        }

        public List<Edge> Get(int v)
            => _adjs[v];

        public int EdgesCount() => _edgesCount;

        public int VerticesCount() => _vertices;
    }
}