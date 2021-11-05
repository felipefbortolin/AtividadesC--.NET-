using System;

namespace Exercicios03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Lista de exercicios 03");
            Console.Write("Por favor escola um exercicio de 1 a 3 ou qualquer outro valor para sair: ");
            int exercicio = int.Parse(Console.ReadLine());
            while (exercicio > 0 && exercicio < 4)
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
                Console.Write("Por favor escolha um exercicio de 1 a 3 ou qualquer outro valor para sair: ");
                exercicio = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Bye bye!");
        }

        static void exercicio01()
        {
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/
            System.Console.WriteLine("Digite a senha :");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {

                System.Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Acesso Permitido");
        }
        static void exercicio02()
        {
            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/
            System.Console.Write("Digite o valor de X e Y separados por espaço: ");
            string[] planos = Console.ReadLine().Split();
            int x = int.Parse(planos[0]);
            int y = int.Parse(planos[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                System.Console.Write("Digite novamente: ");
                planos = Console.ReadLine().Split();
                x = int.Parse(planos[0]);
                y = int.Parse(planos[1]);
            }
        }
        static void exercicio03()
        {
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.*/
            System.Console.WriteLine("Digite as opções : ");
            int x = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int disel = 0;

            while (x != 4)
            {
                if (x == 1)
                {
                    alcool++;
                }
                else if (x == 2)
                {
                    gasolina++;
                }
                else if (x == 3)
                {
                    disel++;
                }

                x = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("MUITO OBRIGADO");
            System.Console.WriteLine("Alcool: " + alcool);
            System.Console.WriteLine("Gasolina: " + gasolina);
            System.Console.WriteLine("Disel: " + disel);
        }
    }
}
