using System;
using System.Collections.Generic;
using Exercicio02.Entities;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Product #{i} data:");
                System.Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (type == 'c' || type == 'C')
                {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u' || type == 'U')
                {
                    System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    System.Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customs));
                }
            }
            System.Console.WriteLine("\nPROCE TAGS:");
            foreach (Product p in list)
            {
                System.Console.WriteLine(p.PriceTag());
            }
        }
    }
}
