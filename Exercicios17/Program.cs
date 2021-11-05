using System;
using System.Collections.Generic;
using Exercicio03.Entities;
using Exercicio03.Entities.Enums;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Shape #{i} data:");
                System.Console.Write("Retangle or Circle (r/c)? ");
                char type = char.Parse(Console.ReadLine());
                System.Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (type == 'r' || type == 'R')
                {
                    System.Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    System.Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Retangle(color, height, width));
                }
                else
                {
                    System.Console.Write("Radius: ");
                    double redius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(color, redius));
                }
            }

            System.Console.WriteLine("\nSHAPE AREAS: ");
            foreach (Shape item in list)
            {
                System.Console.WriteLine(item.Area().ToString("F2"));
            }
        }
    }
}
