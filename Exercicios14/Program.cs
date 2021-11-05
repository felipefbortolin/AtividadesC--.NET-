using System;
using Exercicio03.Entities;
using Exercicio03.Entities.Enums;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Brith date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Client cliente = new Client(name, email, birth);

            System.Console.WriteLine("Enter order data:");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;
            System.Console.Write("How many items tp this order? ");
            int n = int.Parse(Console.ReadLine());
            
            Order order = new Order(moment, status, cliente);
            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Enter #{i} item data:");
                System.Console.Write("Product name: ");
                string pName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                System.Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(pName, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
            }

            System.Console.WriteLine("\n"+order);
        }
    }
}
