using System;
using Topico_14.Entities;


namespace Topico_14.Service
{
    class ContratoServico
    {
        private IPagamentoOnlineServico _PagamentoOnlineServico;

        public ContratoServico(IPagamentoOnlineServico PagamentoOnlineServico)
        {
            _PagamentoOnlineServico = PagamentoOnlineServico;
        }

        public void ProcessoContrato(Contrato contrato, int mes)
        {
            for (int i = 1; i <= mes; i++)
            {
                //Criando um variavel para salvar a data da nova prestação
                DateTime ProximaPrestação = contrato.Data.AddMonths(i);
                //Passando o valor da parcela atualizado 
                double parcela = _PagamentoOnlineServico.Juros((contrato.ValorTotal/mes), i);
                parcela = _PagamentoOnlineServico.TaxaPagamento(parcela);
                //Criando o objeto do tipo prestação com os dados da prestação atual e Passando para o contrato os dados da prestação
                contrato.Prestacoes.Add(new Prestacao(ProximaPrestação, parcela));
            }

        }
    }
}