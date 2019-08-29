namespace Graph
{
    public class ConnectedComponent
    {
        private bool[] _marked;
        private int[] _id;
        private int _count = 0;

        public ConnectedComponent(Graph graph)
        {
            var size = graph.NumberOfVertices();

            _marked = new bool[size];
            _id = new int[size];

            for (int i = 0; i < size; i++)
            {
                if(!_marked[i])
                {
                    DFS(graph, i);
                    _count++;
                }
            }
        }

        public bool IsConnected(int v, int w)
            =>  _id[v] == _id[w];

        public int Count() => _count;

        public int Id(int v) => _id[v];

        private void DFS(Graph graph, int v)
        {
            _marked[v] = true;
            _id[v] = _count;

            foreach (var item in graph.Adjacent(v))
            {
                if(!_marked[item])
                {
                    DFS(graph, item);
                }
            }
        }
    }
}