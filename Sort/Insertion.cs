namespace Sort
{
    public class Insertion
    {
        public static int[] Sort(int[] arr)
        {
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if(arr[j] < arr[j-1])
                    {
                        Swap(arr, j, j-1);
                    }
                }
            }

            return arr;
        }

        private static void Swap(int[] arr, int from, int to)
        {
            var swap = arr[to];
            arr[to] = arr[from];
            arr[from] = swap; 
        }
    }
}