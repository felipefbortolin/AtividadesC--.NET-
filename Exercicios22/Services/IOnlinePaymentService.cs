

namespace Exercicio01.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double interest(double amount, int mounths);

    }
}
