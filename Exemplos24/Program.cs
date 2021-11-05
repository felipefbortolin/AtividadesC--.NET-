using System;
using Exemplo03.Entities;

namespace Exemplo03
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            System.Console.WriteLine(a.Equals(b));
            System.Console.WriteLine(a == b);
            System.Console.WriteLine(a.GetHashCode());
            System.Console.WriteLine(b.GetHashCode());
        }
    }
}
