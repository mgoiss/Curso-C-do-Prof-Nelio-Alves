using System;
using System.Collections.Generic;
using System.Text;

namespace Execicio_Fixação.Entities
{
    class Individual : TaxPayer
    {
        public double GastoSaude { get; set; }

        public Individual(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Tax()
        {
            if(RendaAnual < 20000.00)
            {
                return (RendaAnual * 0.15) - (GastoSaude * 0.50);
            }
            else
            {
                return (RendaAnual * 0.25) - (GastoSaude * 0.50);
            }
        }
    }
}
