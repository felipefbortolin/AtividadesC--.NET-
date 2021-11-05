using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int q = int.Parse(Console.ReadLine());
            Rooms[] vet = new Rooms[10];
            for (int i = 0; i < q; i++)
            {
                System.Console.WriteLine("\nRent #" + (i + 1));
                System.Console.Write("Name: ");
                string nome = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vet[room] = new Rooms{Nome = nome, Email = email};
            }

            System.Console.WriteLine("\nBuys rooms:");
            for (int i = 0; i < 10; i++)
            {
                if(vet[i] != null){
                    System.Console.WriteLine(i+": "+vet[i].Nome+", "+vet[i].Email);
                }
            }
        }
    }
}
