using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double contacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares voce vai comprar? ");
            double dolar = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Valor a ser pago em reais = "+Dolar.Conversao(contacao,dolar).ToString("F2"));
        }
    }
}
