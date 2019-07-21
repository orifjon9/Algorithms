namespace Sort
{
    public class MergeSortBottomUp
    {
        public static string[] Sort(string[] arr)
        {
            var size = arr.Length;
            var lastIndex = size - 1;
            var aux = new string[size];

            for(int i = 1; i <size; i=(2*i))
            {
                for(int j = 0; j < (size - i); j+=(2*i))
                {
                    Merge(arr, aux, j, j+i-1, System.Math.Min((j+(2*i) -1), size - 1));
                }
            }

            return arr;
        }

        private static void Merge(string[] arr, string[] aux, int lo, int mid, int hi)
        {
            if(lo >= hi) return;

            for (int e = lo; e <= hi; e++)
            {
                aux[e] = arr[e];
            }
            var i = lo;
            var j = mid +1;

            for (int k = lo; k <= hi; k++)
            {
                if(i > mid)
                {
                    arr[k] = aux[j++];
                }
                else if(j > hi)
                {
                    arr[k] = aux[i++];
                }
                else if(aux[i].CompareTo(aux[j]) < 0)
                {
                    arr[k] = aux[i++];
                }
                else
                {
                    arr[k] = aux[j++];
                }
            }
        }
    }
}