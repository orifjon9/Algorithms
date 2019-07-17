namespace Sort
{
    public class Selection
    {
        public static int[] Sort(int[] arr)
        {
            
            for(int i = 0; i < (arr.Length - 1); i++)
            {
                var min = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                Swap(arr, i, min);
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