namespace Avaliacao.Exercicio03
{
    public class Veiculo
    {
        private double Velocidade { get; set; }

        public Veiculo()
        {
            Velocidade = 0;
        }

        public virtual void SetVelocidade(double velocidade)
        {
            Velocidade = velocidade;
        }

        public double GetVelocidade()
        {
            return Velocidade;
        }
    }
}
