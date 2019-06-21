using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Topico_10.Entities
{
    class UseProduct : Product
    {
        public DateTime ManufectureDate { get; set; }

        public UseProduct()
        {
        }

        public UseProduct(string name, double price, DateTime manufectureDate) : base (name, price)
        {
            ManufectureDate = manufectureDate;
        }

        public override string PriceTag()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(Name);
            texto.Append(" (usado) R$");
            texto.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            texto.Append(" (Data de Fabricação: ");
            texto.Append(ManufectureDate.ToString("DD/mm/yyyy"));
            texto.Append(")");

            return texto.ToString();
        }
    }
}
