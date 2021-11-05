using System;
using Exercicio01.Entities;

namespace Exercicio01.Services
{
    class PaymentService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public PaymentService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int mounths)
        {
            double amountST = contract.TotalValue / mounths;

            for (int i = 1; i <= mounths; i++)
            {
                double amount = _onlinePaymentService.PaymentFee(_onlinePaymentService.interest(amountST, i));
                DateTime date = contract.Date.AddMonths(i);
                Installment installment = new Installment(date, amount);
                contract.Installments.Add(installment);
            }
        }
    }
}
