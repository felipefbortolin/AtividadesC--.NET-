using System;
using System.Collections.Generic;
using Exercicio01.Entities;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Employee #{i + 1} data:");
                System.Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                double valuePH = double.Parse(Console.ReadLine());
                if (outsourced == 'y' || outsourced == 'Y')
                {
                    System.Console.Write("Additional charge: ");
                    double addcharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePH, addcharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePH));
                }
            }

            System.Console.WriteLine("\nPAYMENTS:");
            foreach (Employee e in list)
            {
                Console.WriteLine(e.Name + " - $ " + e.Payment().ToString("F2"));
            }
        }
    }
}
