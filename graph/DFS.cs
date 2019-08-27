namespace Graph
{
    public class DepthFirstSearch
    {
        private bool[] _marked;
        private int?[] _visitedAdj;
        private readonly int _startIndex;

        public DepthFirstSearch(Graph graph, int startIndex)
        {
            _startIndex = startIndex;

            var vertices = graph.NumberOfVertices();

            _visitedAdj = new int?[vertices];
            _marked = new bool[vertices];

            DFS(graph, startIndex);
        }

        private void DFS(Graph graph, int start)
        {
            _marked[start] = true;
            foreach (var index in graph.Adjacent(start))
            {
                if(_marked[index] != true)
                {
                    DFS(graph, index);
                    _visitedAdj[index] = start;
                }
            }
        }

        public string GetPath(int until)
        {
            if(until >= _visitedAdj.Length)
            {
                throw new System.Exception("There is not path for this destination");
            }

            var path = $"->{until}";
            var index = _visitedAdj[until];

            while(index != null)
            {
                path = $"->{index}" + path;
                index = _visitedAdj[index.Value];
            }

            return path;
        }
    }
}