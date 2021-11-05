using System;
using System.Collections.Generic;
using Exemplo01.Entities;

namespace Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));
            
            list.Sort((p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                System.Console.WriteLine(p);
            }
        }
       
    }
}
