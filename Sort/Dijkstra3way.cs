using System;

namespace Sort
{
    public class Dijkstra3way
    {
        // v = arr[lo]
        // arr[i] < v then swap arr[lt] with arr[i] then lt++ and i++
        // arr[i] > v then swap arr[gt] with arr[i] then gt-- 
        // if equals then just i++;

        public static T[] Sort<T>(T[] arr)
            where T : IComparable
        {
            Sort(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void Sort<T>(T[] arr, int lo, int hi)
            where T : IComparable
        {
            if (lo >= hi) return;
            var v = arr[lo];
            var lt = lo;
            var gt = hi;
            var i = lo + 1;

            while (i <= gt)
            {
                var comp = arr[i].CompareTo(v);
                if (comp < 0)
                {
                    Swap(arr, i++, lt++);
                }
                else if (comp > 0)
                {
                    Swap(arr, i, gt--);
                }
                else
                {
                    i++;
                }
            }

            Sort(arr, lo, lt - 1);
            Sort(arr, gt + 1, hi);
        }

        private static void Swap<T>(T[] arr, int from, int to)
        {
            var swap = arr[to];
            arr[to] = arr[from];
            arr[from] = swap;
        }
    }
}