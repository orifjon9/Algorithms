namespace DS
{
    public class AVLTree<TKey, TValue>
        where TKey : System.IComparable
    {
        public void Put(TKey key, TValue value)
        {

        }


        class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }

            public int Height { get; set; } = 1;

            public Node Left { get; set; }
            public Node Right { get; set; }
        }
    }
}