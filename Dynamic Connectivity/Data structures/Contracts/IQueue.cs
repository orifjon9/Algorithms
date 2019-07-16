namespace DS
{
    public interface IQueue<T>
    {
        void Enqueue(T value);
        T Dequeue();
    }
}