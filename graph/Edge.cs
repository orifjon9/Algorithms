using System;

namespace Graph
{
    public class Edge : IComparable<Edge>
    {
        private readonly int _v;
        private readonly int _w;
        private readonly decimal _weight;

        public Edge(int v, int w, decimal weight)
        {
            _v = v;
            _w = w;
            _weight = weight;
        }

        public int Either() => _v;
        public int Other(int vertex)
            => (vertex == _v ? _w : _v);

        public int CompareTo(Edge that)
        {
            if(this._weight < that._weight)
            {
             return -1;
            } 
            else if(this._weight > that._weight)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }
    }
}