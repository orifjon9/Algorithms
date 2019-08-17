namespace DS
{
    public class AVLTree<TKey, TValue>
        where TKey : System.IComparable
    {
        private Node _root;

        public void Put(TKey key, TValue value)
        {
            _root = Put(_root, key, value);
        }

        private Node Put(Node node, TKey key, TValue value)
        {
            if(node == null)
            {
                node = new Node
                {
                    Key = key,
                    Value = value
                };
            } 
            else
            {
                var comp = key.CompareTo(node.Key);
                if(comp < 0)
                {
                    node.Left = Put(node.Left, key, value);
                }
                else if(comp > 0)
                {
                    node.Right = Put(node.Right, key, value);
                }
                else
                {
                    node.Value = value;
                }

                node.Height = GetHeight(node);

                var balance = GetBalance(node);

                // Left Left
                if(balance > 1 && key.CompareTo(node.Left.Key) < 0)
                {
                    return RightRotate(node);
                }

                // Right Right
                if(balance < -1 && key.CompareTo(node.Right.Key) > 0)
                {
                    return LeftRotate(node);
                }

                // Left Right
                if(balance > 1 && key.CompareTo(node.Left.Key) > 0)
                {
                    node.Left = LeftRotate(node.Left);
                    return RightRotate(node);
                }

                // Right Left
                if(balance < -1 && key.CompareTo(node.Right.Key) < 0)
                {
                    node.Right = RightRotate(node.Right);
                    return LeftRotate(node);
                }
            }
            return node;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            value = default(TValue);
            var node = _root;

            while(node != null)
            {
                var comp = key.CompareTo(node.Key);
                if(comp < 0)
                {
                    node = node.Left;
                }
                else if(comp > 0)
                {
                    node = node.Right;
                }
                else
                {
                    value = node.Value;
                    return true;
                }
            }

            return false;
        }
        
        private int GetBalance(Node node) => (node.Left?.Height ?? 0) - (node.Right?.Height ?? 0);

        private int GetHeight(Node node)
        {
            if(node == null)
            {
                return 0;
            }

            return 1 + System.Math.Max((node.Left?.Height ?? 0), (node.Right?.Height ?? 0));
        }

        private Node LeftRotate(Node parent)
        {
            var rightChild = parent.Right;
            parent.Right = rightChild.Left;
            rightChild.Left = parent;

            parent.Height = GetHeight(parent);
            rightChild.Height = GetHeight(rightChild);

            return rightChild;
        }

        private Node RightRotate(Node parent)
        {
            var leftChild = parent.Left;
            parent.Left = leftChild.Right;
            leftChild.Right = parent;

            parent.Height = GetHeight(parent);
            leftChild.Height = GetHeight(leftChild);
            
            return leftChild;
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