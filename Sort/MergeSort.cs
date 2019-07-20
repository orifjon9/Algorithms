namespace Sort
{
    public class MergeSort
    {
        public static string[] Sort(string[] arr)
        {
            var aux = new string[arr.Length];
            
            Sort(arr, aux, 0, arr.Length - 1);

            return arr;
        }

        private static void Sort(string[] arr, string[] aux, int lo, int hi)
        {
            if(hi <= lo) return;
            int mid = lo + (hi - lo) / 2; 
            Sort(arr, aux, lo, mid);
            Sort(arr, aux, mid + 1, hi);
            Merge(arr, aux, lo, mid, hi);
        }

        private static void Merge(string[] arr, string[] aux, int lo, int mid, int hi)
        {
            var i = lo;
            var j = mid + 1;

            for(int e = lo; e <= hi; e++)
            {
                aux[e] = arr[e];
            }

            for(int k = lo; k <= hi; k++)
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