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

            // var bh = new DS.BinaryHeap<char>(12);
            // bh.Insert('M');
            // bh.Insert('Y');
            // bh.Insert('S');
            // bh.Insert('T');
            // bh.Insert('R');
            // bh.Insert('I');
            // bh.Insert('N');
            // bh.Insert('G');
            // Console.WriteLine(bh.Print());
            // Console.WriteLine(bh.DeleteMax());
            // Console.WriteLine(bh.Print());

            // //var bst = new DS.BST<string, int>();
            // var bst = new DS.RedBlackTree<string, int>();
            // bst.Put("M", 3);
            // bst.Put("Y", 5);
            // bst.Put("S", 1);
            // bst.Put("T", 8);
            // bst.Put("R", 9);
            // bst.Put("I", 2);
            // bst.Put("N", 7);
            // bst.Put("G", 4);
            // bst.Put("X", 3);

            // if (bst.TryGetValue("I", out int value))
            // {
            //     Console.WriteLine(value);
            // }

            // if (bst.TryGetValue("J", out value))
            // {
            //     Console.WriteLine(value);
            // }

            // bst.Put("J", 11);
            // bst.Put("I", 10);

            // if (bst.TryGetValue("I", out value))
            // {
            //     Console.WriteLine(value);
            // }

            // if (bst.TryGetValue("J", out value))
            // {
            //     Console.WriteLine(value);
            // }

            // bst.Print();
            // Console.WriteLine();
            //Console.WriteLine(bst.Min());
            // Console.WriteLine(bst.Max());
            // bst.Remove("S");
            // bst.Print();
            // bst.Remove("T");
            // bst.Print();
            // bst.Remove("Y");
            // bst.Print();

            // var avl = new DS.AVLTree<int, int>();
            // avl.Put(13, 0);
            // avl.Put(10, 0);
            // avl.Put(15, 0);
            // avl.Put(16, 0);
            // avl.Put(11, 0);
            // avl.Put(5, 0);
            // avl.Put(4, 0);
            // avl.Put(8, 0);
            // avl.Put(9, 0);


            // var g = new Graph.Graph(13);
            // g.AddEdge(0, 1);
            // g.AddEdge(0, 2);
            // g.AddEdge(0, 6);
            // g.AddEdge(0, 5);
            // g.AddEdge(6, 4);
            // g.AddEdge(4, 5);
            // g.AddEdge(4, 3);
            // g.AddEdge(5, 0);
            // g.AddEdge(5, 3);

            // g.AddEdge(8, 7);

            // g.AddEdge(9, 10);
            // g.AddEdge(9, 11);
            // g.AddEdge(9, 12);
            // g.AddEdge(11, 12);

            // var dsf = new Graph.DepthFirstSearch(g, 0);

            // Console.WriteLine(dsf.GetPath(5));
            // Console.WriteLine(dsf.GetPath(2));


            // var bsf = new Graph.BFS<Graph.Graph>(g, 0);
            // Console.WriteLine(bsf.GetPath(3));
            // Console.WriteLine(bsf.GetPath(2));

            // var cc = new Graph.ConnectedComponent(g);

            var digraph = new Graph.Digraph(13);
            digraph.AddEdge(4, 2);
            digraph.AddEdge(2,3);
            digraph.AddEdge(3,2);
            digraph.AddEdge(6, 0);
            digraph.AddEdge(0,1);
            digraph.AddEdge(2, 0);
            digraph.AddEdge(11, 12);
            digraph.AddEdge(12, 9);
            digraph.AddEdge(9, 10);
            digraph.AddEdge(9, 11);
            digraph.AddEdge(8, 6);
            digraph.AddEdge(10,12);
            digraph.AddEdge(11, 4);
            digraph.AddEdge(4, 3);
            digraph.AddEdge(3, 5);
            digraph.AddEdge(6, 8);
            digraph.AddEdge(8, 6);
            digraph.AddEdge(5, 4);
            digraph.AddEdge(0, 5);
            digraph.AddEdge(6, 4);
            digraph.AddEdge(6, 9);
            digraph.AddEdge(7, 6);

            var ds = new Graph.DiagramSearch(digraph, 0);
            Console.WriteLine(ds.GetPath(2));

            var ds2 = new Graph.DiagramSearch(digraph, 6);
            Console.WriteLine(ds2.GetPath(5));
            Console.WriteLine(ds2.GetPath(3));
            Console.WriteLine(ds2.GetPath(12));
        }
    }
}