using System;

namespace Exercicio04.Entities
{
    class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }
        public Company()
        {
        }

        public Company(string name, double anuallncome, int numberOfEmployees) : base(name, anuallncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            double tax;
            if (NumberOfEmployees < 10)
            {

                tax = Anuallncome * 0.16;
            }
            else
            {
                tax = Anuallncome * 0.14;
            }
            return tax;
        }
    }
}

