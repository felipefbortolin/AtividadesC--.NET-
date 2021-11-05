﻿using System;
using Exercicio01.Entities;
using Exercicio01.Entities.Enums;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.Write("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double basaSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, basaSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Enter #{i} contract data: ");
                System.Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                System.Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour,hour);
                worker.AddContract(contract);
            }

            System.Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));

            System.Console.WriteLine("Name: "+worker.Name);
            System.Console.WriteLine("Department: "+worker.Department.Name);
            System.Console.WriteLine("Income for "+monthAndYear + ": " + worker.Income(year,month).ToString("F2"));
        }
    }
}
