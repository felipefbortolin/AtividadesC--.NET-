using System;
using System.Text;

namespace Exercicio02.Entities
{
    class UsedProduct : Product
    {

        public DateTime ManufactureDate { get; set; }
        
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price,DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} (used) $ {Price.ToString("F2")} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})");
            return sb.ToString();
        }
    }
}
