using System.Collections.Generic;

namespace Graph
{
    public class EdgeWeightedDigraph
    {
        private readonly int _vertices;
        private List<DirectedEdge>[] _adj;

        public EdgeWeightedDigraph(int v)
        {
            _vertices = v;
            _adj = new List<DirectedEdge>[v];

            for (int i = 0; i < v; i++)
            {
                _adj[i] = new List<DirectedEdge>();
            }
        }

        public void AddEdge(DirectedEdge directedEdge)
        {
            _adj[directedEdge.From].Add(directedEdge);
        }

        public List<DirectedEdge> Adj(int v) => _adj[v];
    }

    public class DirectedEdge
    {
        public DirectedEdge(int from, int to, decimal weight)
        {
            this.From = from;
            this.To = to;
            this.Weight = weight;
        }

        public int From { get; set; }
        public int To { get; set; }
        public decimal Weight { get; set; }
    }
}