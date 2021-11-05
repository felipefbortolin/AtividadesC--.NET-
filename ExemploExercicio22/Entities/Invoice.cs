using System.Globalization;

namespace ExemploInterfaces01.Entities
{
    class Invoice
    {
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public double TotalPayment { get { return BasicPayment + Tax; } }

        public override string ToString()
        {
            return "Basic payment: "
            +BasicPayment.ToString("F2",CultureInfo.InvariantCulture)
            +"\nTax: "
            +Tax.ToString("F2",CultureInfo.InvariantCulture)
             +"\nTotal Payment: "
            +TotalPayment.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
