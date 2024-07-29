using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paypal.Entities
{
    internal class Contrato
    {

        public int Numero { get; set; }
        public DateTime Date { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestacao> Prestacao { get; set; }

        public Contrato() { }

        public Contrato(int numero, DateTime date, double totalValue)
        {
            Numero = numero;
            Date = date;
            ValorTotal = totalValue;
            Prestacao = new List<Prestacao>();
        }

        public void AdicionaPrestacao(Prestacao prestacao)
        {
            Prestacao.Add(prestacao);
        }
    }
}
