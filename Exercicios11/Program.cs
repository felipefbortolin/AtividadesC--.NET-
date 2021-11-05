using System;

namespace Exercicio03
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] xy = Console.ReadLine().Split(' ');
            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);

            int[,] mat = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < y; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }
            int consult = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mat[i, j] == consult)
                    {
                        System.Console.WriteLine("Position " + i + "," + j);
                        if (j > 0)
                        {
                            System.Console.WriteLine("Left: " + mat[i, (j - 1)]);
                        }
                        if (j < x - 1)
                        {
                            System.Console.WriteLine("Right: " + mat[i, (j + 1)]);
                        }
                        if (i > 0)
                        {
                            System.Console.WriteLine("Up: " + mat[(i - 1), j]);
                        }
                        if (i < y - 1)
                        {
                            System.Console.WriteLine("Down: " + mat[(i + 1), j]);
                        }
                    }
                }
            }
        }
    }
}
