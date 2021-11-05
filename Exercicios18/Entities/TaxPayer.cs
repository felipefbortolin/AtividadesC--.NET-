using System;

namespace Exercicio04.Entities
{
    abstract class TaxPayer
    {

        public string Name { get; set; }
        public double Anuallncome { get; set; }
        
        protected TaxPayer()
        {
        }

        protected TaxPayer(string name, double anuallncome)
        {
            Name = name;
            Anuallncome = anuallncome;
        }

        public abstract double Tax();
    }
}
