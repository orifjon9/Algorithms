using System.Collections.Generic;

namespace Graph
{
    public class BFS<TGraph>
        where TGraph : IGraph
    {
        private int?[] _visited;
        private int[] _cc;
        private Queue<int> _queue = new Queue<int>();

        public BFS(TGraph graph, int startIndex)
        {
            var count = graph.NumberOfVertices();

            _visited = new int?[count];
            _cc = new int[count];

            _visited[startIndex] = startIndex;
           _queue.Enqueue(startIndex);

            Init(graph);
        }

        private void Init(TGraph graph)
        {
            var count = 0;
            while(true)
            {
                if(_queue.TryDequeue(out int index))
                {
                    foreach (var item in graph.Adjacent(index))
                    {
                        if(_visited[item] == null)
                        {
                            _visited[item] = index;
                            _cc[item] = count;
                            _queue.Enqueue(item);
                        }
                    }
                    count++;
                }
                else
                {
                    break;
                }
            }
        }

        public string GetPath(int until)
        {
            if(until >= _visited.Length)
            {
                throw new System.Exception("There is not path for this destination");
            }

            var path = $"->{until}";
            int? index = until;

            while(index != 0)
            {
                index = _visited[index.Value];
                path = $"->{index}" + path;
            }

            return path;
        }

    }
}