using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha entre os exercicios 1 e 3 : ");
            int exercicio = int.Parse(Console.ReadLine());
            while (exercicio >= 1 || exercicio <= 3)
            {
                if (exercicio == 1)
                {
                    exercicio01();
                }
                else if (exercicio == 2)
                {
                    exercicio02();
                }
                else
                {
                    exercicio03();
                }
                Console.Write("Escolha entre os exercicios de 1 a 3 : ");
            }
            System.Console.WriteLine("Bye Bye!");
        }




        static void exercicio01()
        {
            Retangulo x;
            x = new Retangulo();
            System.Console.WriteLine("Entre a largura e altura do retângulo:");
            x.Largura = double.Parse(Console.ReadLine());
            x.Altura = double.Parse(Console.ReadLine());

            System.Console.WriteLine("AREA = " + x.Area().ToString("F2"));
            System.Console.WriteLine("PERIMETRO = " + x.Perimetro().ToString("F2"));
            System.Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2"));
        }
        static void exercicio02()
        {
            Funcionario x;
            x = new Funcionario();
            System.Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            System.Console.Write("Salario bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine());
            System.Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine());

            System.Console.WriteLine(x);

            System.Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine());
            x.AumentarSalario(porcentagem);

            System.Console.WriteLine(x);
        }
        static void exercicio03()
        { 
            Aluno x;
            x = new Aluno();
            System.Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite as tres notas do aluno: ");
            x.Nota1 = double.Parse(Console.ReadLine());
            x.Nota2 = double.Parse(Console.ReadLine());
            x.Nota3 = double.Parse(Console.ReadLine());
            System.Console.WriteLine(x);
        }
    }
}

