using System.Collections.Generic;
using System.Linq;

namespace Graph
{
    public class KruskalMST
    {
        private Queue<Edge> _queue = new Queue<Edge>();

        public KruskalMST(EdgeWeightedGraph ewg)
        {
            var edges = new List<Edge>();
            foreach (var edge in ewg.AllEdges())
            {
                edges.Add(edge);
            }

            edges.Sort();  

            var quickUnion = new DC.QuickUnion(ewg.VerticesCount());
            while(edges.Count != 0)
            {
                var minEdge = edges.ElementAt(0);
                var v = minEdge.Either();
                var w = minEdge.Other(v);

                if(!quickUnion.Connected(v, w))
                {
                    quickUnion.Union(v, w);
                    _queue.Enqueue(minEdge);
                }

                edges.RemoveAt(0);
            }
        }
    }
}