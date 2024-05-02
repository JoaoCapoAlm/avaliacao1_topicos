namespace Avaliacao.Exercicio03
{
    public class Carro : Veiculo
    {
        private int Marcha { get; set; }

        public Carro()
        {
            Marcha = 1;
        }

        public int GetMarcha()
        {
            return Marcha;
        }

        public override void SetVelocidade(double velocidade)
        {
            base.SetVelocidade(velocidade);

            if (velocidade < 20)
                Marcha = 1;
            else if (velocidade >= 20 && velocidade < 40)
                Marcha = 2;
            else if (velocidade >= 40 && velocidade < 60)
                Marcha = 3;
            else if (velocidade >= 60 && velocidade <= 70)
                Marcha = 4;
            else
                Marcha = 5;
        }
    }

}
