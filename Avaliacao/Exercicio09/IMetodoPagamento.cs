namespace Avaliacao.Exercicio09
{
    public interface IMetodoPagamento
    {
        public void RealizarPagamento();
        public StatusPagamentoEnum StatusPagamento();
    }
}
