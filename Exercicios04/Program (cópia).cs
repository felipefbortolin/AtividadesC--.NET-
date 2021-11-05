using System;

namespace Exercicios04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a lista 04!");
            Console.Write("Escolha um exercicio de 1 a 7: ");
            int x = int.Parse(Console.ReadLine());

            while (x > 0 && x <= 7)
            {
                if (x == 1)
                {
                    exercicio01();
                    Console.Write("Escolha um exercicio de 1 a 7: ");
                    x = int.Parse(Console.ReadLine());
                }
                else if (x == 2)
                {
                    exercicio02();
                    Console.Write("Escolha um exercicio de 1 a 7: ");
                    x = int.Parse(Console.ReadLine());
                }
                else if (x == 3)
                {
                    exercicio03();
                    Console.Write("Escolha um exercicio de 1 a 7: ");
                    x = int.Parse(Console.ReadLine());
                }
                else if (x == 4)
                {
                    exercicio04();
                    Console.Write("Escolha um exercicio de 1 a 7: ");
                    x = int.Parse(Console.ReadLine());
                }
                else if (x == 5)
                {
                    exercicio05();
                    Console.Write("Escolha um exercicio de 1 a 7: ");
                    x = int.Parse(Console.ReadLine());
                }
                else if (x == 6)
                {
                    exercicio06();
                    Console.Write("Escolha um exercicio de 1 a 7: ");
                    x = int.Parse(Console.ReadLine());
                }
                else
                {
                    exercicio07();
                    Console.Write("Escolha um exercicio de 1 a 7: ");
                    x = int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("Bye bye!");
        }

        static void exercicio01()
        {
            /*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.*/
            System.Console.Write("Digite um valor inteiro: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                if ((i % 2) != 0)
                {
                    System.Console.WriteLine(i);
                }
            }

        }
        static void exercicio02()
        {
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/
            System.Console.Write("Digite a quantidade de valores que ira digitar : ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;


            for (int i = 1; i <= n; i++)
            {
                int v = int.Parse(Console.ReadLine());
                if (v >= 10 && v <= 20)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }

            System.Console.WriteLine(a + " in");
            System.Console.WriteLine(b + " out");
        }
        static void exercicio03()
        {
            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.*/
            System.Console.Write("Digite a quantidade de casos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] v = Console.ReadLine().Split(" ");
                double a = double.Parse(v[0]);
                double b = double.Parse(v[1]);
                double c = double.Parse(v[2]);
                double media = (a * 2 + b * 3 + c * 5) / 10;
                System.Console.WriteLine(media.ToString("F1"));
            }


        }
        static void exercicio04()
        {
            /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".*/
            System.Console.Write("Digite a quantidade de casos : ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                string[] y = Console.ReadLine().Split(" ");
                double a = double.Parse(y[0]);
                double b = double.Parse(y[1]);
                if (b == 0)
                {
                    System.Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double result = a / b;
                    System.Console.WriteLine(result.ToString("F1"));
                }
            }
        }
        static void exercicio05()
        {
            /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.*/
            System.Console.Write("Digite o valor: ");
            int x = int.Parse(Console.ReadLine());
            int fatorial = x;
            if (x == 0)
            {
                fatorial = 1;
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    if (i != x)
                    {
                        fatorial = fatorial * (x - i);
                    }
                }
            }
            System.Console.WriteLine(fatorial);
        }
        static void exercicio06()
        {
            /*Ler um número inteiro N e calcular todos os seus divisores.*/
            System.Console.Write("Digite um valor: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        static void exercicio07()
        {
/*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
exemplo.*/
            System.Console.Write("Digite o valor: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i++){
                System.Console.WriteLine(i +" "+Math.Pow(i,2)+" "+Math.Pow(i,3));
            }
        }
    }
}