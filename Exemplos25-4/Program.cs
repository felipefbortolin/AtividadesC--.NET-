
using System;
using System.Collections.Generic;
using Exemplo04.Entities;

namespace Exemplo04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*
            //list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                System.Console.WriteLine(p);
            }*/

            //Action<Product> act = p => { p.Price += p.Price * 0.1;}

            //list.ForEach(UpdatePrice);
            //list.ForEach(act);
            list.ForEach(p => { p.Price += p.Price * 0.1;});
            foreach (Product p in list)
            {
                System.Console.WriteLine(p);
            }
        }
        /*public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }*/

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
