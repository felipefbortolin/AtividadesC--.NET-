using System;
using System.Collections.Generic;
using System.IO;
using ExercicioResolvido.Entities;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            System.Console.WriteLine("Enter file full path");
            string path = "/home/felipe/Área de Trabalho/Curso de C#/Capitulo15-Generic-Set-Dictionary/ws-vs2021-cap15/ExercicioResolvido/in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });

                    }
                    System.Console.WriteLine("Total users: " + set.Count);
                }

            }
            catch (IOException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}

