using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = (Console.ReadLine());
            Console.Write("Haverá deposito inicial (s/n)?  ");
            char condicao = char.Parse(Console.ReadLine());
            if (condicao == 's' || condicao == 'S')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numero, nome, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, nome);
            }

            System.Console.WriteLine("\nDados da conta:");
            System.Console.WriteLine(conta);

            System.Console.Write("\nEntre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);

            System.Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);
        }
    }
}
