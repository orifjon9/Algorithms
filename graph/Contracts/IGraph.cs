using System.Collections.Generic;

namespace Graph
{
    public interface IGraph
    {
        void AddEdge(int v, int w);
        List<int> Adjacent(int vertice);
        int NumberOfVertices();
        int NumberOfEdges();
    }
}