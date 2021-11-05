using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Exercicio01 Capitulo13");
                string actualPath = Directory.GetCurrentDirectory();
                string newPath = CriarDiretorio(actualPath);
                List<string> newLines = FormarNovoArquivo(actualPath);
                CriarNovoArquivo(newPath, newLines);
                System.Console.WriteLine("Executado com sucesso");
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Error:");
                System.Console.WriteLine(e.Message);
            }
        }

        public static string CriarDiretorio(string actualPath)
        {
            string newPath = actualPath + "/out";
            if (Directory.Exists(newPath))
            {
                Directory.Delete(newPath,true);
                Directory.CreateDirectory(newPath);
            }
            else
            {
                Directory.CreateDirectory(newPath);
            }
            return newPath;
        }
        public static List<string> FormarNovoArquivo(string actualPath)
        {
            string file = actualPath + "/file.csv";
            List<string> lines = new List<string>();
            string[] vet;
            using (StreamReader sr = File.OpenText(file))
            {
                while (!sr.EndOfStream)
                {
                    vet = sr.ReadLine().Split(',');
                    string name = vet[0];
                    double value = double.Parse(vet[1], CultureInfo.InvariantCulture);
                    int qtd = int.Parse(vet[2]);
                    lines.Add(name + "," + (value * qtd).ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            return lines;
        }

        public static void CriarNovoArquivo(string newPath, List<string> lines)
        {
            using (StreamWriter sw = File.AppendText(newPath + "/summary.csv"))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
    }
}
