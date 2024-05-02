namespace Avaliacao.Exercicio06
{
    public class Veiculo
    {
        private double Velocidade { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo()
        {
            Velocidade = 0;
        }

        public virtual void SetVelocidade(double velocidade)
        {
            Velocidade = velocidade;
        }

        public double GetVelocidade() { return Velocidade; }
    }
}
