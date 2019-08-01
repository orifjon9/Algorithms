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

        public void Remove(TKey key) {
           _root = Remove(_root, key);
           _root.Size = Size(_root);
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
                    Value = value,
                    Size = 1
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

            node.Size = 1 + (node.Left?.Size ?? 0) + (node.Right?.Size ?? 0);

            return node;
        }

        private Node Remove(Node node, TKey key)
        {
            if (node != null)
            {
                var comp = key.CompareTo(node.Key);
                if (comp < 0)
                {
                    node.Left = Remove(node.Left, key);
                }
                else if (comp > 0)
                {
                    node.Right = Remove(node.Right, key);
                }
                else
                {
                    if (node.Left == null && node.Right == null)
                    {
                        return null;
                    }
                    else if (node.Right == null)
                    {
                        var newNode = node.Left;
                        newNode.Size = Size(newNode);
                        return newNode;
                    }
                    else if (node.Left == null)
                    {
                        var newNode = node.Right;
                        newNode.Size = Size(newNode);
                        return newNode;
                    }

                    var minNodeOnRight = Min(node.Right);
                    node.Key = minNodeOnRight.Key;
                    node.Value = minNodeOnRight.Value;
                    node.Right = Remove(node.Right, minNodeOnRight.Key);
                }

                node.Size = Size(node);
            }

            return node;
        }

        private int Size(Node node) => 1 + (node.Left?.Size ?? 0) + (node.Right?.Size ?? 0);

        private void InOrder(Node node)
        {
            if (node == null) return;

            InOrder(node.Left);
            Console.Write($"[{node.Key}, {node.Value}, {node.Size}] ");
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