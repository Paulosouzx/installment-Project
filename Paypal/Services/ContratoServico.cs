using System;
using Paypal.Entities;

namespace Paypal.Services
{
    internal class ContratoServico
    {

        private IOnlinePaymentService _onlinePaymentService;

        public ContratoServico(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ContratoProcesso(Contrato contrato, int meses)
        {
            double quota = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++) {
               DateTime data = contrato.Date.AddMonths(i);
                double quotaJurosMensais = quota + _onlinePaymentService.Juros(quota, i);
                double quotaTotal = quotaJurosMensais + _onlinePaymentService.TaxaPagar(quotaJurosMensais);
                contrato.AdicionaPrestacao(new Prestacao(data, quotaTotal));
            }
        }


    }
}
