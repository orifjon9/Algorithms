using System;

namespace DS
{
    public class BinaryHeap<T>
        where T : IComparable
    {
        private T[] _bucket;
        private int _index = 0;

        public BinaryHeap(int size)
        {
            _bucket = new T[size];
        }

        public void Insert(T value)
        {
            _bucket[++_index] = value;
            Swim(_index);
        }

        public T Max() => _bucket[1];

        public T DeleteMax()
        {
            var max = _bucket[1];
            Swap(1, _index--);
            Sink(1);
            _bucket[_index + 1] = default(T);
            return max;
        }

        private void Swim(int k)
        {
            while (k > 1 && Less(k / 2, k))
            {
                Swap(k / 2, k);
                k = k / 2;
            }
        }

        private void Sink(int k)
        {
            while (2 * k <= _index)
            {
                var child = 2 * k;
                if(child < _index && Less(child, child + 1)) 
                {
                    child++;
                }
                if(!Less(k, child)) break;
                Swap(k, child);
                k = child;
            }
        }

        private bool Less(int i, int j)
            => _bucket[i].CompareTo(_bucket[j]) < 0;

        private void Swap(int i, int j)
        {
            var swap = _bucket[i];
            _bucket[i] = _bucket[j];
            _bucket[j] = swap;
        }

        public string Print()
            => String.Join(',', _bucket);
    }
}