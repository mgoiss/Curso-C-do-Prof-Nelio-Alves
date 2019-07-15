namespace Topico_14.Service
{
    interface IPagamentoOnlineServico
    {
        double TaxaPagamento(double montante);
        double Juros(double montante, int mes);
    }
}
