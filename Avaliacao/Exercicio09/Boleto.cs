namespace Avaliacao.Exercicio09
{
    public class Boleto : IMetodoPagamento
    {
        public string Codigo { get; set; }
        public decimal Valor { get; set; }
        public DateOnly DataVencimento { get; set; }
        public StatusPagamentoEnum Status { get; set; }

        public void RealizarPagamento()
        {
            Status = StatusPagamentoEnum.Pago;
        }

        public StatusPagamentoEnum StatusPagamento()
        {
            return Status;
        }
    }
}
