using System;

namespace DC
{
    public static class Main
    {
        public static void Run()
        {
            var uf = new UnionFind(10);
            uf.Union(1, 2);
            uf.Union(2, 7);
            uf.Union(3, 8);
            uf.Union(8, 9);
            uf.Union(4, 9);
            uf.Union(0, 1);
            Console.WriteLine(uf.Connected(0, 9));
            Console.WriteLine(uf.Connected(0, 7));
            Console.WriteLine(uf.Connected(3, 4));
            Console.WriteLine(uf.Connected(5, 0));
            Console.WriteLine(uf.Connected(6, 7));
            uf.Union(7, 8);
            Console.WriteLine(uf.Connected(0, 9));
        }
    }
}