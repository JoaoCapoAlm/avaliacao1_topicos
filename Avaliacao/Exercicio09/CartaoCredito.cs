namespace Avaliacao.Exercicio09
{
    public class CartaoCredito : IMetodoPagamento
    {
        public Conta Conta { get; set; }
        public StatusPagamentoEnum Status { get; set; }

        public CartaoCredito()
        {
            Conta = new Conta();
        }

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
