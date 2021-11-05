using System;
using System.Globalization;

namespace Exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercicio (1,2,3,4,5,6,7 ou 8):");
            int exercicio = int.Parse(Console.ReadLine());
            if (exercicio == 1)
            {
                exercicio01();
            }
            else if (exercicio == 2)
            {
                exercicio02();
            }
            else if (exercicio == 3)
            {
                exercicio03();
            }
            else if (exercicio == 4)
            {
                exercicio04();
            }
            else if (exercicio == 5)
            {
                exercicio05();
            }
            else if (exercicio == 6)
            {
                exercicio06();
            }
            else if (exercicio == 7)
            {
                exercicio07();
            }
            else if (exercicio == 8)
            {
                exercicio08();
            }
        }

        static void exercicio01()
        {
            System.Console.WriteLine("Exercicio 01.");
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            System.Console.WriteLine("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 0)
            {
                System.Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                System.Console.WriteLine("NEGATIVO");
            }
        }
        static void exercicio02()
        {
            System.Console.WriteLine("Exercicio 02.");
            System.Console.WriteLine("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                System.Console.WriteLine("PAR");
            }
            else
            {
                System.Console.WriteLine("IMPAR");
            }
        }
        static void exercicio03()
        {
            System.Console.WriteLine("Exercicio 03.");
            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente*/
            System.Console.WriteLine("Digite dois numeors inteiros na mesma linha:");
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                System.Console.WriteLine("Sao Multiplos");
            }
            else
            {
                System.Console.WriteLine("Nao sao Multiplos");
            }
        }
        static void exercicio04()
        {
            /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/
            System.Console.WriteLine("Exercicio 04.");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
        static void exercicio05()
        {
            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.*/
            System.Console.WriteLine("Exercicio 05.");
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double total = 0;

            if (codigo == 1)
            {
                total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;
            }
            System.Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
        static void exercicio06()
        {
            /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/
            System.Console.WriteLine("Exercicio 06.");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0) {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            }
            else {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
        static void exercicio07()
        {
            /*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
situação.*/
            System.Console.WriteLine("Exercicio 07.");
            System.Console.WriteLine("Digite 2 valores com uma casa decimal na mesma linha:");
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if( x == y && x == 0){
                System.Console.WriteLine("Origem");
            }else if(x == 0 && y != 0){
                System.Console.WriteLine("Eixo X");
            }else if(y == 0 && x != 0){
                System.Console.WriteLine("Eixo Y");
            }else if(x > 0 && y > 0){
                System.Console.WriteLine("Q1");
            }else if(x < 0 && y > 0){
                System.Console.WriteLine("Q2");
            }else if(x < 0 && y < 0){
                System.Console.WriteLine("Q3");
            }else if(x > 0 && y < 0){
                System.Console.WriteLine("Q4");
            }
        }
        static void exercicio08()
        {
            /*Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
duas casas decimais.*/
            System.Console.WriteLine("Exercicio 08.");
            System.Console.WriteLine("Digite o valor do salario:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0;

            if(salario <= 2000){
                imposto = 0.0;
            }else if(salario <= 3000){
                imposto = (salario - 2000.0) * 0.08;
            }else if(salario <= 4500){
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }else {
                 imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
