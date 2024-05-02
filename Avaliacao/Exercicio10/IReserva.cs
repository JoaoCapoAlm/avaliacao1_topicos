namespace Avaliacao.Exercicio10
{
    public interface IReserva
    {
        //reserva de voo regular, reserva de voo com upgrade de classe e reserva de voo para grupos grandes. 
        public void Reservar();

        public void Cancelar();

        public StatusReservaEnum Status();
    }
}
