using System;

namespace Exemplo04.Entities
{
    class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
