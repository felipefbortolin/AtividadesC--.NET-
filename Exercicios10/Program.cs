using System;
using System.Collections.Generic;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registred? ");
            int qtd = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for (int i = 1; i <= qtd; i++)
            {
                System.Console.WriteLine("\nEmployee #" + i);
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
            }
            System.Console.Write("\nEnter the employee id that will have salary increase : ");
            int inConsult = int.Parse(Console.ReadLine());


            Employee emp = list.Find(x => x.Id == inConsult);
            if (emp != null)
            {
                System.Console.Write("Enter the percentage : ");
                double percent = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

System.Console.WriteLine("\nUpdated list of employees:");
            foreach (object element in list)
            {
                System.Console.WriteLine(element);
            }
        }
    }
}
