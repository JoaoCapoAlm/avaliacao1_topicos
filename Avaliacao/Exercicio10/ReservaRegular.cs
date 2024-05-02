namespace Avaliacao.Exercicio10
{
    public class ReservaRegular : Reserva, IReserva
    {
        public ReservaRegular(string cpf, string codigoVoo, string assento, decimal valorReserva)
            : base(cpf, codigoVoo, assento, valorReserva)
        {    
        }

        public void Cancelar()
        {
            AlterarStatus(StatusReservaEnum.Cancelado);
        }

        public void Reservar()
        {
            AlterarStatus(StatusReservaEnum.EsperandoPagamento);
        }

        public void EfetivarPagamento()
        {
            AlterarStatus(StatusReservaEnum.Reservado);
        }

        public StatusReservaEnum Status()
        {
            return GetStatusReserva();
        }
    }
}
