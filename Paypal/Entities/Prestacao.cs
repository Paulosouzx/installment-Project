using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Paypal.Entities
{
    internal class Prestacao
    {

        public DateTime DataVencimento { get; set; }
        public double Montante { get; set; }

        public Prestacao(DateTime dataVencimento, double montante)
        {
            DataVencimento = dataVencimento;
            Montante = montante;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Montante.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}