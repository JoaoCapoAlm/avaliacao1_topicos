namespace Avaliacao.Exercicio09
{
    public class Trasferencia : IMetodoPagamento
    {
        public Conta ContaOriginal { get; set; }
        public Conta ContaDestino { get; set; }
        public Pedido Pedido { get; set; }
        public Trasferencia()
        {
            ContaOriginal = new Conta();
            ContaDestino = new Conta();
            Pedido = new Pedido();
        }

        public void RealizarPagamento()
        {
            if (ContaOriginal.Saldo >= Pedido.Preco)
                ContaOriginal.Saldo -= Pedido.Preco;

            ContaDestino.Saldo += Pedido.Preco;
            Pedido.StatusPagamento = StatusPagamentoEnum.Pago;
        }

        public StatusPagamentoEnum StatusPagamento()
        {
            return Pedido.StatusPagamento;
        }
    }
}
