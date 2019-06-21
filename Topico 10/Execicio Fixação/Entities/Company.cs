using System;
using System.Collections.Generic;
using System.Text;

namespace Execicio_Fixação.Entities
{
    class Company : TaxPayer
    {
        public int NumeroFuncionario { get; set; }

        public Company(String nome, double rendaAnual, int numeroFuncionario) : base(nome, rendaAnual)
        {
            NumeroFuncionario = numeroFuncionario;
        }

        public override double Tax()
        {
            if (NumeroFuncionario > 10)
            {
                return (RendaAnual * 0.14);
            }
            else
            {
                return (RendaAnual * 0.16);
            }
        }
    }
}
