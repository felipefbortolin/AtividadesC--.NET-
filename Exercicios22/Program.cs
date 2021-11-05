using System;
using System.Globalization;
using Exercicio01.Entities;
using Exercicio01.Services;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            System.Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            System.Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.Write("Enter number of installments: ");
            int q = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number,date,totalValue);
            PaymentService payment = new PaymentService(new PaypalService());
            payment.ProcessContract(contract,q);

            System.Console.WriteLine("Installments:");
            foreach (Installment x in contract.Installments)
            {
                System.Console.WriteLine(x);
            }
        }
    }
}
