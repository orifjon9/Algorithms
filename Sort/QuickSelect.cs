using System;

namespace Sort
{
    public class QuickSelect
    {
        public static T Find<T>(T[] arr, int k)
            where T : IComparable
        {
            arr = Sort.Shuffle.Run(arr);

            k -= 1;
            var lo = 0;
            var hi = arr.Length - 1;

            while (hi > lo)
            {
                var j = Partition(arr, lo, hi);
                if (j < k)
                {
                    lo = j + 1;
                }
                else if (j > k)
                {
                    hi = j - 1;
                }
                else
                {
                    return arr[k];
                }
            }
            return arr[k];
        }

        private static int Partition<T>(T[] arr, int lo, int hi)
            where T : IComparable
        {
            var key = arr[lo];
            var i = lo;
            var j = hi + 1;

            while (true)
            {
                while (arr[++i].CompareTo(key) < 0)
                {
                    if (i == hi) break;
                }

                while (arr[--j].CompareTo(key) > 0)
                {
                    if (j == lo) break;
                }

                if (i >= j) break;
                Swap(arr, i, j);
            }

            Swap(arr, lo, j);

            return j;
        }

        private static void Swap<T>(T[] arr, int from, int to)
            where T : IComparable
        {
            var swap = arr[to];
            arr[to] = arr[from];
            arr[from] = swap;
        }
    }
}