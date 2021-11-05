using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Exercicio02.Entities;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string path = Directory.GetCurrentDirectory() + "/in.csv";
            System.Console.Write("Enter Salary: ");
            double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            System.Console.WriteLine("Email of people whose salary is more than " + value.ToString("F2", CultureInfo.InvariantCulture));

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2],CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }

            var emails = list.Where(p => p.Salary > value).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string em in emails)
            {
                System.Console.WriteLine(em);
            }

            var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            System.Console.WriteLine("Sum of salary people whose name strats with 'M': "+sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
