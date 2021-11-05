using System;
using System.Collections.Generic;
using Exercicio01.Entities;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int id = int.Parse(Console.ReadLine());
                students.Add(new Student(id));
            }

            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                int id = int.Parse(Console.ReadLine());
                students.Add(new Student(id));
            }

            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                int id = int.Parse(Console.ReadLine());
                students.Add(new Student(id));
            }

            System.Console.WriteLine("Total students: " + students.Count);
        }
    }
}
