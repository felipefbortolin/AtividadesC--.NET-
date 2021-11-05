using System;
using System.Collections.Generic;

namespace Exemplo05
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                System.Console.WriteLine(cookies["email"]);
            }
            else
            {
                System.Console.WriteLine("There is no 'email' key");
            }

            System.Console.WriteLine("Size: " + cookies.Count);

            System.Console.WriteLine("All Cookies:");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                System.Console.WriteLine(item.Key+", "+item.Value);
            }
        }
    }
}
