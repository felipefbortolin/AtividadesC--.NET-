

namespace Exercicio01.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double interest(double amount, int mounths)
        {
            return amount += amount * 0.01 * mounths;
        }

        public double PaymentFee(double amount)
        {
            return amount += amount * 0.02;
        }
    }
}
