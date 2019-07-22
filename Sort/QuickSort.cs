using System;

namespace Sort
{
    public class QuickSort
    {
        public static T[] Sort<T>(T[] arr)
            where T: IComparable
        {

            arr = Shuffle.Run(arr);

            Sort(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void Sort<T>(T[] arr, int lo, int hi)
            where T: IComparable
        {
            if(lo >= hi) return;

            var mid = Partition(arr, lo, hi);
            Sort(arr, lo, mid);
            Sort(arr, mid + 1, hi);
        }

        private static int Partition<T>(T[] arr, int lo, int hi)
            where T: IComparable
        {
            var key = arr[lo];
            var i = lo;
            var j = hi + 1;

            while(true)
            {
                while(arr[++i].CompareTo(key) < 0)
                {
                    if(i == hi) break;
                }

                while(key.CompareTo(arr[--j]) < 0)
                {
                    if(j == lo) break;
                }

                if(i >= j) break;
                Swap(arr, i, j);
            }

            Swap(arr, lo, j);
            return j;
        }

        private static void Swap<T>(T[] arr, int from, int to)
            where T: IComparable
        {
            if(arr[to].CompareTo(arr[from]) != 0)
            {
                var swap = arr[to];
                arr[to] = arr[from];
                arr[from] = swap;
            }
        }
    }
}