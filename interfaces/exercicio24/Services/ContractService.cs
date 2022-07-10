using exercicio24.Entities;
using System;

namespace exercicio24.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double parcel = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                double interest = parcel + _onlinePaymentService.Interest(parcel, i);
                double quota = parcel + _onlinePaymentService.PaymentFee(interest);

                DateTime dueDate = contract.Date.AddMonths(i);

                contract.AddInstallment(new Installment(dueDate, quota));
            }
        }
    }
}
