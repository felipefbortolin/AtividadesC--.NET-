using System;

namespace Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintService<string> printService = new PrintService<string>();
            PrintService<int> printService = new PrintService<int>();

            System.Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                //x = Console.ReadLine();
                printService.AddValue(x);

            }

            int a = (int)printService.First();
            int b = a + 2;
            System.Console.WriteLine(b);

            printService.Print();
            System.Console.WriteLine("First: " + printService.First());

        }
    }
}
