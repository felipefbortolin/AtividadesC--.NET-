using System;
using System.Collections.Generic;
using System.Text;
using Exercicio03.Entities.Enums;

namespace Exercicio03.Entities
{
    class Order
    {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();


        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total(){
            double total = 0;
            foreach (OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status.ToString()}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yy")}) - {Client.Email}");
            sb.AppendLine("Order item:");
            foreach (OrderItem o in OrderItems)
            {
                sb.AppendLine($"{o.Product.Name}, ${o.Price.ToString("F2")}, Quantity: {o.Quantity}, Subtotal: ${o.SubTotal().ToString("F2")}");
            }
             sb.AppendLine($"Total price: ${Total().ToString("F2")}");
            return sb.ToString();
        }
    }
}
