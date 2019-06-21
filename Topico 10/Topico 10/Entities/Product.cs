using System.Globalization;
using System.Text;

namespace Topico_10.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(Name);
            texto.Append(" R$");
            texto.Append(Price.ToString("F2", CultureInfo.InvariantCulture));

            return texto.ToString();
        }
    }
}
