namespace Avaliacao.Exercicio10
{
    public class Reserva
    {
        public string Cpf { get; set; }
        public string CodigoVoo { get; set; }
        public string Assento { get; set; }
        public ClasseEnum Classe { get; set; }
        public DateTime DataReserva { get; set; }
        public decimal ValorReserva { get; set; }
        private StatusReservaEnum StatusReserva { get; set; }

        public Reserva(string cpf, string codigoVoo, string assento)
        {
            Assento = assento;
            Cpf = cpf;
            CodigoVoo = codigoVoo;
            DataReserva = DateTime.Now;
            StatusReserva = StatusReservaEnum.EsperandoPagamento;
        }

        public Reserva(string cpf, string codigoVoo, string assento, decimal valorReserva)
        {
            Assento = assento;
            Cpf = cpf;
            CodigoVoo = codigoVoo;
            DataReserva = DateTime.Now;
            ValorReserva = valorReserva;
            StatusReserva = StatusReservaEnum.EsperandoPagamento;
        }

        public void AlterarStatus(StatusReservaEnum statusReserva)
        {
            StatusReserva = statusReserva;
        }

        public StatusReservaEnum GetStatusReserva() {
            return StatusReserva;
        }
    }
}
