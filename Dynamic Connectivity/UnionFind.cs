namespace DC 
{
    public class UnionFind 
    {
        private int[] _bucket;

        public UnionFind(int size)
        {
            _bucket = new int[size];
            for (int i = 0; i < size; i++)
            {
                _bucket[i] = i;
            }
        }

        public void Union(int p, int q)
        {
            var pIndex = _bucket[p];
            
            for (int i = 0; i < _bucket.Length; i++)
            {
                if(_bucket[i] == pIndex)
                {
                    _bucket[i] = _bucket[q];
                }
            }
        }

        public bool Connected(int p, int q)
        {
            return _bucket[p] == _bucket[q];
        }
    }
}