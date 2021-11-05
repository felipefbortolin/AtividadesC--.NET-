using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha entre os exercicios 1 e 2 : ");
            int exercicio = int.Parse(Console.ReadLine());
            while (exercicio == 1 || exercicio == 2)
            {
                if (exercicio == 1)
                {
                    exercicio01();
                }
                else
                {
                    exercicio02();
                }
                Console.Write("Escolha entre os exercicios 1 e 2 : ");
                exercicio = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Bye Bye!");
        }




        static void exercicio01()
        {
            /*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            velha.*/
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            System.Console.WriteLine("Dados da primeira pessoa:");
            System.Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da segundo pessoa:");
            System.Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                System.Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else { System.Console.WriteLine("Pessoa mais velha: " + p2.nome); }
        }
        static void exercicio02()
        {
            /*Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            médio dos funcionários.*/
            Funcionario f1,f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            System.Console.WriteLine("Dados da primeiro funcionário:");
            System.Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            System.Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da segundo funcionário:");
            System.Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            System.Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Salário médio = "+ ((f1.salario + f2.salario)/2).ToString("F2"));
        }
    }
}

