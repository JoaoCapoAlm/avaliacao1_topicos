namespace Avaliacao.Exercicio07
{
    public class ContaPoupanca : Conta
    {
        public decimal Juros { get; set; }
        public ContaPoupanca(decimal juros)
        {
            Juros = juros;
        }
        public decimal CalcularJuros()
        {
            return Saldo * Juros;
        }
    }
}
