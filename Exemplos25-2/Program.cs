using System;
using Exemplo02.Services;

namespace Exemplo02
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double resutl = op(a,b);
            System.Console.WriteLine(resutl);
        }
    }
}
