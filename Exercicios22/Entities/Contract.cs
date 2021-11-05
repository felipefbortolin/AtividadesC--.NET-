using System;
using System.Collections.Generic;

namespace Exercicio01.Entities
{
    class Contract
    {
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public int Number  { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; } = new List<Installment>();
    }
}
