namespace Avaliacao.Exercicio07
{
    public class ContaEmpresarial : Conta
    {
        public decimal SaldoMinimo { get; set; }
        public ContaEmpresarial(decimal saldoMinimo)
        {
            SaldoMinimo = saldoMinimo;
        }
    }
}
