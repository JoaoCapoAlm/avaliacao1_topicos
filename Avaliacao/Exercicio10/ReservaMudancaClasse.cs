namespace Avaliacao.Exercicio10
{
    public class ReservaMudancaClasse : Reserva, IReserva
    {
        public ReservaMudancaClasse(string cpf, string codigoVoo, string assento, decimal valorReserva)
            : base(cpf, codigoVoo, assento)
        {
            valorReserva *= (decimal)0.9;
            ValorReserva = valorReserva;
        }

        public void Cancelar()
        {
            AlterarStatus(StatusReservaEnum.Cancelado);
        }

        public void Reservar()
        {
            AlterarStatus(StatusReservaEnum.Reservado);
        }

        public StatusReservaEnum Status()
        {
            return GetStatusReserva();
        }
    }
}
