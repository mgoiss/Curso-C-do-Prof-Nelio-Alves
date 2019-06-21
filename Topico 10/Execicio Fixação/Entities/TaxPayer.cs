using System.Globalization;

namespace Execicio_Fixação.Entities
{
    abstract class TaxPayer
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        protected TaxPayer(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return Nome + ", R$" + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
