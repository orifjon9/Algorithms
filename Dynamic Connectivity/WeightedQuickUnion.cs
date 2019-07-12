namespace DC
{
    public class WeightedQuickUnion
    {
        private int[] _bucket;
        private int[] _size;
        public WeightedQuickUnion(int size)
        {
            _bucket = new int[size];
            _size = new int[size];

            for (int i = 0; i < size; i++)
            {
                _bucket[i] = i;
                _size[i] = 0;
            }
        }

        private int Root(int index)
        {
            while (index != _bucket[index])
            {
                index = _bucket[index];
            }
            return index;
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            var pRoot = Root(p);
            var qRoot = Root(q);

            if (_size[pRoot] < _size[qRoot])
            {
                _bucket[pRoot] = qRoot;
                _size[qRoot] = _size[qRoot] + _size[pRoot] + 1;
            }
            else
            {
                _bucket[qRoot] = pRoot;
                _size[pRoot] = _size[pRoot] + _size[qRoot] + 1;
            }
        }

        public string Print()
        {
            var result = "array: " + string.Join(',', _bucket);
            result += "\n size: " + string.Join(',', _size);

            return result;
        }
    }
}