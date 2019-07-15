using System;
using System.Globalization;

namespace Topico_14.Entities
{
    class Prestacao
    {
        public DateTime Vencimento { get; set; }
        public double Montante { get; set; }

        public Prestacao(DateTime vencimento, double montante)
        {
            Vencimento = vencimento;
            Montante = montante;
        }

        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yyyy") 
                + " - " 
                + Montante.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
