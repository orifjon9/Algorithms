using System;

namespace DC
{
    public static class Main
    {
        public static void Run()
        {
            #region QuickFindUF
            // var uf = new QuickFindUF(10);
            // uf.Union(1, 2);
            // uf.Union(2, 7);
            // uf.Union(3, 8);
            // uf.Union(8, 9);
            // uf.Union(4, 9);
            // uf.Union(0, 1);
            // Console.WriteLine(uf.Connected(0, 9));
            // Console.WriteLine(uf.Connected(0, 7));
            // Console.WriteLine(uf.Connected(3, 4));
            // Console.WriteLine(uf.Connected(5, 0));
            // Console.WriteLine(uf.Connected(6, 7));
            // uf.Union(7, 8);
            // Console.WriteLine(uf.Connected(0, 9));
            #endregion

            #region QuickUnion
            // var qu = new QuickUnion(10);
            // qu.Union(4,3);
            // qu.Union(3,8);
            // qu.Union(6,5);
            // qu.Union(9,4);
            // qu.Union(2,1);
            // Console.WriteLine(qu.Connected(8, 9)); // true
            // Console.WriteLine(qu.Connected(5, 4)); // false
            // qu.Union(5, 0);
            // qu.Union(7, 2);
            // qu.Union(6, 1);
            // qu.Union(7, 3);
            #endregion

            #region WeightedQuickUnion
            var wqu = new WeightedQuickUnion(10);
            wqu.Union(4, 3);
            wqu.Union(3, 8);
            wqu.Union(6, 5);
            wqu.Union(9, 4);
            wqu.Union(2, 1);
            wqu.Union(5, 0);
            wqu.Union(7, 2);
            wqu.Union(6, 1);
            wqu.Union(7, 3);
            Console.WriteLine(wqu.Print());
            #endregion
        }
    }
}