using System;
using System.Linq;
using System.Collections.Generic;

namespace Exemplo06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression
            IEnumerable<int> result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * 10);

            // Execute  the querry
            foreach (int x in result)
            {
                System.Console.WriteLine(x);
            }
        }
    }
}
