namespace HashTable
{
    public class LinearProbingHT<TKey, TValue>
        where TKey : System.IComparable
    {
        private const int size = 3000;

        private TKey[] keys = new TKey[size];
        private TValue[] values = new TValue[size];


        private int GetHashCode(TKey key)
        {
            return (key.GetHashCode() & 0x7fffffff) % size;
        }

        public void Put(TKey key, TValue value)
        {
            var index = GetHashCode(key);
            while(keys[index] != null)
            {
                if(keys.Equals(keys[index]))
                {
                    break;
                }

                index = (index + 1) % size;
            }

            keys[index] = key;
            values[index] = value;
        }

        public TValue GetValue(TKey key)
        {
            var index = GetHashCode(key);
            while(keys[index] != null)
            {
                if(key.Equals(keys[index]))
                {
                    return values[index];
                }

                index = (index + 1) % size;
            }

            throw new System.Exception("Key was not found");
        }
    }
}