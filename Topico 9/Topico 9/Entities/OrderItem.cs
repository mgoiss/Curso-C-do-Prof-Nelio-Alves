using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Topico_9.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {

            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(Product.Name);
            texto.Append(", R$");
            texto.Append(Product.Price.ToString("F2", CultureInfo.InvariantCulture));
            texto.Append(", Quantidade: ");
            texto.Append(Quantity);
            texto.Append(", SubTotal: R$");
            texto.Append(SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            return texto.ToString();     
        }
    }
}
