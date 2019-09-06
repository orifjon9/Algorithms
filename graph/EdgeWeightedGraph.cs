using System.Collections.Generic;

namespace Graph
{
    public class EdgeWeightedGraph
    {
        private readonly int _vertices;
        private List<Edge>[] _adjs;
        private List<Edge> _allEdges = new List<Edge>();

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

            _allEdges.Add(edge);
        }

        public List<Edge> Get(int v)
            => _adjs[v];

        public List<Edge> AllEdges() => _allEdges;

        public int EdgesCount() => _allEdges.Count;

        public int VerticesCount() => _vertices;
    }
}