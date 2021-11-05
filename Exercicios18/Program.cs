using System;
using System.Collections.Generic;
using Exercicio04.Entities;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Tax payer #{i} data:");
                System.Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine());
                if (type == 'i' || type == 'I')
                {
                    System.Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualincome, health));
                }
                else
                {
                    System.Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualincome, employees));
                }
            }

            System.Console.WriteLine("\nTAXES PAID:");
            double totalTax = 0;
            foreach (TaxPayer item in list)
            {
                totalTax += item.Tax();
                System.Console.WriteLine($"{item.Name}: $ {item.Tax().ToString("F2")}");
            }
            System.Console.WriteLine($"\nTOTAL TAXES: $ {totalTax.ToString("F2")}");
        }
    }
}
