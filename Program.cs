using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //DC.Main.Run();

            //var sortedArray = Sort.Selection.Sort(new int[] {7, 10, 5, 3, 8, 4, 2, 9, 6});
            //Console.WriteLine(String.Join(',', sortedArray));

            var sortedArray = Sort.Insertion.Sort(new int[] {7, 10, 5, 3, 8, 4, 2, 9, 6});
            Console.WriteLine(String.Join(',', sortedArray));
        }
    }
}
