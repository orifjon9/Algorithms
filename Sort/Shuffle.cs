namespace Sort
{
    public class Shuffle
    {
        public static T[] Run<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int random = new System.Random().Next(i, arr.Length);
                Swap(arr, i, random);
            }
            return arr;
        }

        private static void Swap<T>(T[] arr, int from, int to)
        {
            var swap = arr[to];
            arr[to] = arr[from];
            arr[from] = swap;
        }
    }
}