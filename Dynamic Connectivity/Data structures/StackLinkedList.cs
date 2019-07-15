namespace DS
{
    public class StackLinkedList<T> : IStack<T>
    {
        private Node Head { get; set; }

        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        public bool IsEmpty() => Head == null;

        public void Push(T value)
        {
            var newNode = new Node { Data = value };
            newNode.Next = Head;

            Head = newNode;
        }

        public T Peek() => Head.Data;

        public T Pop()
        {
            var value = Head.Data;
            Head = Head.Next;

            return value;
        }
    }
}