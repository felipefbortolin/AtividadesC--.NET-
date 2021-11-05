using System;
using System.Globalization;

namespace Exercicio01.Entities
{
    class Installment
    {
        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy") 
            +" - "
            + Amount.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
