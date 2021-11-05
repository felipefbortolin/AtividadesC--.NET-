using System;
using System.Collections.Generic;
using Exemplo04.Entities;

namespace Exemplo04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            System.Console.WriteLine(set.Contains("Computer"));

            foreach (string p in set)
            {
                System.Console.WriteLine(p);
            }*/


            /*
            //union
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference
             SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
            */

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            System.Console.WriteLine(a.Contains(prod));

            Point p = new Point(5,10);
            System.Console.WriteLine(b.Contains(p));
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                System.Console.Write(obj + " ");
            }
            System.Console.WriteLine();
        }
    }
}
