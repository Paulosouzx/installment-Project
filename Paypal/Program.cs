using Paypal.Entities;
using Paypal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paypal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do Contrato: ");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor contrato: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Digite o numero de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);

            ContratoServico contratoServico = new ContratoServico(new PaypalService());

            contratoServico.ContratoProcesso(contrato, meses);

            Console.WriteLine("PRESTACAO");

            foreach(Prestacao prestacao in contrato.Prestacao)
            {
                Console.WriteLine(prestacao);
            }


            Console.ReadKey();



        }
    }
}
