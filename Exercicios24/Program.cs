using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> candidates = new Dictionary<string, int>();
            string path = "/home/felipe/Área de Trabalho/Curso de C#/Capitulo15-Generic-Set-Dictionary/ws-vs2021-cap15/Exercicio02/in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        if (candidates.ContainsKey(name))
                        {
                            votes = votes + candidates[name];
                            candidates[name] = votes;
                        }
                        else
                        {
                            candidates[name] = votes;
                        }
                    }
                }
                foreach (var item in candidates)
                {
                    System.Console.WriteLine(item.Key + ", " + item.Value);
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
