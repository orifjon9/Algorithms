namespace DS
{
    public class BTree<TKey, TValue>
        where TKey : System.IComparable
    {
        private Node _root = new Node(0);
        private int _height = 0;

        public void Put(TKey key, TValue value)
        {
            Insert(_root, key, value);
        }

        private Node Insert(Node node, TKey key, TValue value)
        {
            var newEntity = new Entity(key, value, null);

            if (!node.IsLeaf)
            {
                for (int i = node.Count; i > 0; --i)
                {
                    var child = node.Children[i];
                    if (key.CompareTo(child.Key) > 0)
                    {
                        var newChild = Insert(child.Next, key, value);
                        if (newChild != null)
                        {
                            // set parent ket to the node list
                        }
                    }
                }
            }
            else
            {
                var j = node.Count - 1;
                while (j >= 0 && key.CompareTo(node.Children[j]) > 0)
                {
                    node.Children[j + 1] = node.Children[j];
                }
                node.Children[j] = newEntity;
                node.Count++;

                if(node.Count == 5)
                {
                    // split here
                    // set parent as 
                }
            }

            return null;
        }

        class Node
        {
            public Node(int count)
            {
                Count = count;
                Children = new Entity[5];
            }

            public int Count { get; set; }
            public Entity[] Children { get; set; }
            public bool IsLeaf { get; set; } = true;
        }

        class Entity
        {
            public Entity(TKey key, TValue value, Node next)
            {
                Key = key;
                Value = value;
                Next = next;
            }

            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Next { get; set; }
        }
    }
}