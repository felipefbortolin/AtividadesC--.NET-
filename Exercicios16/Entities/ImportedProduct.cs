using System.Text;

namespace Exercicio02.Entities
{
    class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} $ {TotalPrice().ToString("F2")} (Customs fee: $ {CustomsFee.ToString("F2")})");
            return sb.ToString();
        }
    }
}
