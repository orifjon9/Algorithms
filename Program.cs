using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //DC.Main.Run();

            // var sortedArray = Sort.Selection.Sort(new int[] {7, 10, 5, 3, 8, 4, 2, 9, 6});
            // Console.WriteLine(String.Join(',', sortedArray));

            // var sortedArray = Sort.Insertion.Sort(new int[] {7, 10, 5, 3, 8, 4, 2, 9, 6});
            // Console.WriteLine(String.Join(',', sortedArray));

            //var shellSort = Sort.ShellSort.Sort(new string[] { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E"});
            //Console.WriteLine(String.Join(',', shellSort));

            //var merge = Sort.MergeSort.Sort(new string[] { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" });
            //Console.WriteLine(String.Join(',', merge));

            //var merge = Sort.MergeSortBottomUp.Sort(new string[] { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" });
            //Console.WriteLine(String.Join(',', merge));

            //var shuffledArray = Sort.Shuffle.Run(new string[] { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" });
            //Console.WriteLine(String.Join(',', shuffledArray));

            //var sortedArray = Sort.QuickSort.Sort(new string[] { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" });
            //Console.WriteLine(String.Join(',', sortedArray));

            //Console.WriteLine(Sort.QuickSelect.Find(new string[] { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" }, 6));
            //Console.WriteLine(Sort.QuickSelect.Find(new string[] { "X","M","R","S","O","E","T","P","L","A","E" }, 6));

            //var sortedArray = Sort.Dijkstra3way.Sort(new string[] { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" });
            //Console.WriteLine(String.Join(',', sortedArray));

            var bh = new DS.BinaryHeap<char>(12);
            bh.Insert('M');
            bh.Insert('Y');
            bh.Insert('S');
            bh.Insert('T');
            bh.Insert('R');
            bh.Insert('I');
            bh.Insert('N');
            bh.Insert('G');
            Console.WriteLine(bh.Print());
            Console.WriteLine(bh.DeleteMax());
            Console.WriteLine(bh.Print());

            //var bst = new DS.BST<string, int>();
            var bst = new DS.RedBlackTree<string, int>();
            bst.Put("M", 3);
            bst.Put("Y", 5);
            bst.Put("S", 1);
            bst.Put("T", 8);
            bst.Put("R", 9);
            bst.Put("I", 2);
            bst.Put("N", 7);
            bst.Put("G", 4);
            bst.Put("X", 3);

            if (bst.TryGetValue("I", out int value))
            {
                Console.WriteLine(value);
            }

            if (bst.TryGetValue("J", out value))
            {
                Console.WriteLine(value);
            }

            bst.Put("J", 11);
            bst.Put("I", 10);

            if (bst.TryGetValue("I", out value))
            {
                Console.WriteLine(value);
            }

            if (bst.TryGetValue("J", out value))
            {
                Console.WriteLine(value);
            }

            bst.Print();
            Console.WriteLine();
            //Console.WriteLine(bst.Min());
            // Console.WriteLine(bst.Max());
            // bst.Remove("S");
            // bst.Print();
            // bst.Remove("T");
            // bst.Print();
            // bst.Remove("Y");
            // bst.Print();
        }
    }
}