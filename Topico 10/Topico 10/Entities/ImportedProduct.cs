using System;
using System.Globalization;
using System.Text;

namespace Topico_10.Entities
{
    class ImportedProduct : Product
    {
        public Double CustomsFee { get; set; }

        public ImportedProduct()
        {        
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(Name);
            texto.Append(" R$");
            texto.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            texto.Append(" (Taxa: R$");
            texto.Append(CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            texto.Append(")");

            return texto.ToString();
        }
    }
}
