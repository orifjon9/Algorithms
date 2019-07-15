namespace DS
{
    public class StackArrayList<T> : IStack<T>
    {
        private T[] _store = new T[4];
        private int _index = -1;

        public bool IsEmpty() => _index == -1;
        
        public void Push(T value)
        {
            if(_index == _store.Length)
            {
                var newArr = new T[_store.Length * 2];
                System.Array.Copy(_store, newArr, _store.Length);

                _store = newArr;
            }

            _store[++_index] = value;
        }

        public T Peek() => _store[_index];

        public T Pop()
        {
            var item = _store[_index];
            _store[_index--] = default(T);
            return item;
        }

    }
}