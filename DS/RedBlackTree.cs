using System;

namespace DS
{
    public class RedBlackTree<TKey, TValue>
        where TKey : IComparable
    {
        private Node _root;

        public void Put(TKey key, TValue value)
        {
            _root = Put(_root, key, value);
        }

        private Node Put(Node node, TKey key, TValue value)
        {
            if (node == null)
            {
                node = new Node(key, value);
            }
            else
            {
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
            }

            if (IsRed(node.Right) && !IsRed(node.Left)) node = RotateLeft(node);
            if (IsRed(node.Left) && IsRed(node.Left?.Left)) node = RotateRight(node);
            if (IsRed(node.Left) && IsRed(node.Right)) FlipColors(node);

            return node;
        }

        private bool IsRed(Node node)
        {
            if (node == null) return false;

            return node.IsRed;
        }

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

        public void Remove(TKey key)
        {
            //TODO: Implementation here
        }

        public void Print()
        {
            Console.WriteLine();
            InOrder(_root);
        }
        private void InOrder(Node node)
        {
            if (node == null) return;

            InOrder(node.Left);
            Console.Write($"[{node.Key}, {node.Value}] ");
            InOrder(node.Right);
        }

        private Node RotateLeft(Node parent)
        {
            var rightChild = parent.Right;
            parent.Right = rightChild.Left;
            rightChild.IsRed = parent.IsRed;
            parent.IsRed = true;
            rightChild.Left = parent;

            return rightChild;
        }

        private Node RotateRight(Node parent)
        {
            var leftChild = parent.Left;
            parent.Left = leftChild.Right;
            leftChild.Right = parent;
            leftChild.IsRed = parent.IsRed;
            parent.IsRed = true;

            return leftChild;
        }

        private void FlipColors(Node parent)
        {
            parent.IsRed = true;
            parent.Left.IsRed = false;
            parent.Right.IsRed = false;
        }

        class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public bool IsRed { get; set; } = true;

            public Node(TKey key, TValue value)
            {
                this.Key = key;
                this.Value = value;
                this.IsRed = true;
            }

            public Node Left { get; set; } = null;
            public Node Right { get; set; } = null;
        }
    }
}
