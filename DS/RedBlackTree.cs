using System;

namespace DS
{
    public class RedBlackTree<TKey, TValue>
        where TKey : IComparable
    {

        public void Put(TKey key, TValue value)
        {

        }

        public TValue GetValue(TKey key)
        {
            return default;
        }

        class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public bool IsRed { get; set; }
        }
    }
}