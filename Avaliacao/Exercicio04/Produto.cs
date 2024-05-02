namespace Avaliacao.Exercicio04
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        private int QuantidadeEmEstoque { get; set; }

        public Produto()
        {
            QuantidadeEmEstoque = 0;
        }

        public void AdicionarProdutoEstoque(int qtd = 1)
        {
            QuantidadeEmEstoque += qtd;
        }

        public void RemoverProdutoEstoque(int qtd = 1)
        {
            QuantidadeEmEstoque -= qtd;
        }

        public int QtdEstoque()
        {
            return QuantidadeEmEstoque;
        }
    }
}
