namespace DS
{
    public class QuickUnion
    {
        private int[] _bucket;
        public QuickUnion(int size)
        {
            if(size < 1)
            {
                throw new System.Exception("Negative a size");
            }

            _bucket = new int[size];
            for(int i = 0; i < size; i++)
            {
                _bucket[i] = i;
            }
        }

        private int Root(int p)
        {
            while(p != _bucket[p])
            {
                p = _bucket[p];
            }

            return p;
        }

        public void Union(int p, int q)
        {
            var pRoot = Root(p);
            var qRoot = Root(q);
            _bucket[pRoot] = qRoot;
        }

        public bool Connected(int p, int q)
        {
            var pRoot = Root(p);
            var qRoot = Root(q);
            return pRoot == qRoot;
        }
    }
}