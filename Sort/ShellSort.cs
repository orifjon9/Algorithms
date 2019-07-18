namespace Sort
{
    public class ShellSort
    {
        public static string[] Sort(string[] arr)
        {
            var size = arr.Length;
            var h = 1;

            // find max h size for an array
            while (h < (size / 3))
            {
                h = (3 * h + 1);
            }

            while (h > 0)
            {

                for(int i = h; i < size; i++)
                {
                    for (int j = i; j >= h; j -= h)
                    {
                        if(arr[j].CompareTo(arr[j - h]) < 0)
                        {
                            Swap(arr, j, j-h);
                        }
                    }
                }

                h = h / 3;
            }


            return arr;
        }

        private static void Swap(string[] arr, int from, int to)
        {
            var value = arr[to];
            arr[to] = arr[from];
            arr[from] = value;
        }
    }
}