using System.Collections.Generic;
using System.Linq;

namespace Graph
{
    // Topological sort
    public class DepthFirstOrder
    {
        private bool[] _marked;
        private Stack<int> _postOrder = new Stack<int>();

        public DepthFirstOrder(Digraph graph)
        {
            var size = graph.NumberOfVertices();

            _marked = new bool[size];

            for (int i = 0; i < size; i++)
            {
                if(!_marked[i])
                {
                    DFO(graph, i);
                }
            }
        }

        public void DFO(Digraph graph, int index)
        {
            _marked[index] = true;

            foreach (var item in graph.Adjacent(index))
            {
                if(!_marked[item])
                {
                    DFO(graph, item);
                }
            }

            _postOrder.Push(index);
        }

        public List<int> Order()
            => _postOrder.ToList<int>();

    }
}