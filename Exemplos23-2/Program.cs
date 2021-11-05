using System;
using System.Collections.Generic;
using System.Globalization;
using Exemplo02.Entities;
using Exemplo02.Service;


namespace Exemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Product> list = new List<Product>();

           System.Console.Write("Enter N: ");
           int n = int.Parse(Console.ReadLine());

           for (int i = 0; i < n; i++)
           {
               string[] vect = Console.ReadLine().Split(',');
               string name = vect[0];
               double price = double.Parse(vect[1],CultureInfo.InvariantCulture);
               //int x = int.Parse(Console.ReadLine());
               list.Add(new Product(name,price));
           }

           CalculationService calculationService = new CalculationService();

           Product max = calculationService.Max(list);

           System.Console.WriteLine("Max: ");
           System.Console.WriteLine(max);
        }
    }
}
