using System;
using Exercicio02.Entities;
using Exercicio02.Entities.Exeptions;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                System.Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                System.Console.Write("Holder: ");
                string holder = Console.ReadLine();
                System.Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                System.Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                System.Console.Write("\nEnter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, initialBalance, withdrawLimit);
                account.Withdraw(withdraw);
                System.Console.WriteLine(account);
            }
            catch (DomainExceptions e)
            {
                System.Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
