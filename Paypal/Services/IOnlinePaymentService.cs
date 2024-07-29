namespace Paypal.Services
{
     interface IOnlinePaymentService
    {
       double TaxaPagar(double montante);
        double Juros(double montante, int meses);
        

    }
}
