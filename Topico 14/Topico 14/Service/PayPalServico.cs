namespace Topico_14.Service
{
    class PayPalServico : IPagamentoOnlineServico
    {
        public double TaxaPagamento(double montante)
        {
            return montante + (montante * 0.02);
        }

        public double Juros(double montante, int mes)
        {
            return ( montante + ((montante * 0.01) * mes));
        }
    }
}
