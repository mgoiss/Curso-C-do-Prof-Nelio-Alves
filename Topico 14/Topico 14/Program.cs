using System;
using Topico_14.Entities;
using Topico_14.Service;
using System.Globalization;

namespace Topico_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os Dados do Contrato");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do Contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número de Parcelas: ");
            int numeroParcelas = int.Parse(Console.ReadLine());

            //Criando o objeto Contrato
            Contrato contrato = new Contrato(numero, data, valorContrato);
            //Criando o Serviço para processar o contrator
            ContratoServico contratoServico = new ContratoServico(new PayPalServico());
            //Chamando a operação responsável por criar as prestações e adcionar ao contrato atual
            contratoServico.ProcessoContrato(contrato, numeroParcelas);

            Console.WriteLine("Parcelas: ");
            foreach (Prestacao item in contrato.Prestacoes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
