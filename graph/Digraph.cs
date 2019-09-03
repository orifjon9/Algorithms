using System.Collections.Generic;

namespace Graph
{
    public class Digraph : IGraph
    {
        private readonly int _vertices;
        private List<int>[] _edgeAdj;
        private int _adgesCount = 0;

        public Digraph(int vertices)
        {
            _vertices = vertices;
            _edgeAdj = new List<int>[vertices];

            for (int i = 0; i < vertices; i++)
            {
                _edgeAdj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            _edgeAdj[v].Add(w);
            _adgesCount++;
        }

        public List<int> Adjacent(int v) => _edgeAdj[v];

        public int NumberOfVertices() => _vertices;

        public int NumberOfEdges() => _adgesCount;
    }
}