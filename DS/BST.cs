using System;

namespace DS
{
    public class BST<TKey, TValue>
        where TKey : IComparable
    {
        private Node _root = null;

        public void Put(TKey key, TValue value)
            => _root = Put(_root, key, value);

        public bool TryGetValue(TKey key, out TValue value)
        {
            var node = _root;

            while (node != null)
            {
                var comp = key.CompareTo(node.Key);
                if (comp < 0)
                {
                    node = node.Left;
                }
                else if (comp > 0)
                {
                    node = node.Right;
                }
                else
                {
                    value = node.Value;
                    return true;
                }
            }

            value = default(TValue);
            return false;
        }

        public TKey Max()
        {
            var maxNode = Max(_root);
            if (maxNode != null)
            {
                return maxNode.Key;
            }

            throw new Exception("BST is empty");
        }

        public TKey Min()
        {
            var minNode = Min(_root);
            if (minNode != null)
            {
                return minNode.Key;
            }

            throw new Exception("BST is empty");
        }

        public void Print()
        {
            Console.WriteLine();
            InOrder(_root);
        }

        private Node Put(Node node, TKey key, TValue value)
        {
            if (node == null)
            {
                return new Node
                {
                    Key = key,
                    Value = value
                };
            }

            var comp = key.CompareTo(node.Key);
            if (comp < 0)
            {
                node.Left = Put(node.Left, key, value);
            }
            else if (comp > 0)
            {
                node.Right = Put(node.Right, key, value);
            }
            else
            {
                node.Value = value;
            }

            return node;
        }

        private void InOrder(Node node)
        {
            if (node == null) return;

            InOrder(node.Left);
            Console.Write($"[{node.Key}, {node.Value}] ");
            InOrder(node.Right);
        }

        private Node Min(Node node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }

        private Node Max(Node node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }

            return node;
        }
        class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public int Size { get; set; }

            public Node Left { get; set; } = null;
            public Node Right { get; set; } = null;
        }
    }
}