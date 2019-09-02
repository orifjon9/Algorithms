using System.Collections.Generic;

namespace Graph
{
    public class Graph : IGraph
    {
        private readonly int numberOfVertices;
        private List<int>[] adj;

        private int numberOfEdges = 0;

        public Graph(int vertices)
        {
            numberOfVertices = vertices;
            adj = new List<int>[vertices];

            for (int i = 0; i < vertices; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(v);
            numberOfEdges++;
        }

        public List<int> Adjacent(int vertice) => adj[vertice];

        public int NumberOfVertices() => numberOfVertices;

        public int NumberOfEdges() => numberOfEdges;
    }
}