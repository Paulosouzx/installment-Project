using System;
using Paypal.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paypal.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double TaxaPagamento = 0.02;
        private const double JurosMensais = 0.01;

        public PaypalService()
        {
        }

        public double Juros(double montante, int meses)
        {
            return montante * JurosMensais * meses;

        }

        public double TaxaPagar(double montante)
        {
            return montante * TaxaPagamento;
        }
    }
}
