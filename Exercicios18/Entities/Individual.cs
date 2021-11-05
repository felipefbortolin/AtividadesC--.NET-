using System;

namespace Exercicio04.Entities
{
    class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }
        public Individual()
        {
        }

        public Individual(string name, double anuallncome, double healthExpenditures) : base(name, anuallncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double tax;
            if (Anuallncome < 20000)
            {
                tax = Anuallncome * 0.15;
            }
            else
            {
                tax = Anuallncome * 0.25;
            }
            if (HealthExpenditures > 0)
            {
                tax -= HealthExpenditures * 0.5;
            }
            return tax;
        }
    }
}
