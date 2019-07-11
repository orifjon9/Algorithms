namespace DC 
{
    public class QuickFindUF 
    {
        private int[] _bucket;

        public QuickFindUF(int size)
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
            var qIndex  = _bucket[q];
            
            for (int i = 0; i < _bucket.Length; i++)
            {
                if(_bucket[i] == pIndex)
                {
                    _bucket[i] = qIndex;
                }
            }
        }

        public bool Connected(int p, int q)
        {
            return _bucket[p] == _bucket[q];
        }
    }
}