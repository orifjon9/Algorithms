namespace DS
{
    public class QueueLinkedList<T> : IQueue<T>
    {
        private Node _first;
        private Node _last;

        class Node 
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        public void Enqueue(T value)
        {
            var newNode = new Node { Data = value };

            if(_first == null)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                _last.Next = newNode;
                _last = newNode;
            }
        }

        public T Dequeue()
        {
            var item = _first.Data;
            _first = _first.Next;
            if(_first == null)
            {
                _last = null;
            }

            return item;
        }
    }
}