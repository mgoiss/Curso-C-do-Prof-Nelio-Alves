using System;
using Topico_9.Entities.Enum;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Topico_9.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
            Items = new List<OrderItem>();
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Add(item);
        }

        public double Total()
        {
            double Sum = 0.0;

            foreach  (OrderItem valor in Items)
            {
                Sum += valor.SubTotal();
            }

            return Sum;
        }

        public override string ToString()
        {
            //Formatando o Texto
            StringBuilder summa = new StringBuilder();
            summa.AppendLine("SUMARIO:");
            summa.Append("Data da Compra: ");
            summa.AppendLine(Moment.ToString());
            summa.Append("Status: ");
            summa.AppendLine(Status.ToString());
            summa.Append("Clente: ");
            summa.Append(Client.Name);
            summa.Append(" (");
            summa.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            summa.Append(") - ");
            summa.AppendLine(Client.Email);
            summa.AppendLine("Itens:");
            foreach (OrderItem item in Items)
            {
                summa.AppendLine(item.ToString());
            }
            summa.Append("Preço Total: ");
            summa.AppendLine(Total().ToString("F2", CultureInfo.InstalledUICulture));

            return summa.ToString();
        }
    }
}
