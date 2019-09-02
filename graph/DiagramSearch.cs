namespace Graph
{
    public class DiagramSearch
    {
        private int?[] _visitedAdj;
        private bool[] _marked;
        public DiagramSearch(Digraph digraph, int startIndex)
        {
            var size = digraph.NumberOfVertices();

            _visitedAdj = new int?[size];
            _marked = new bool[size];

            DS(digraph, startIndex);
        }

        private void DS(Digraph digraph, int index)
        {
            _marked[index] = true;

            foreach (var item in digraph.Adjacent(index))
            {
                if(!_marked[item])
                {
                    DS(digraph, item);
                    _visitedAdj[item] = index;
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