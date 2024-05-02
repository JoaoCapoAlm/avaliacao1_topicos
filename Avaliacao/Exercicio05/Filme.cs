namespace Avaliacao.Exercicio05
{
    public class Filme
    {
        private string Titulo { get; set; }
        private string Genero { get; set; }
        private int Duracao { get; set; }
        private bool Disponivel { get; set; }

        public Filme(string titulo, string genero, int duracao)
        {
            Titulo = titulo;
            Genero = genero;
            Duracao = duracao;
        }

        public void LocarFilme()
        {
            Disponivel = false;
        }

        public void DevolverFilme()
        {
            Disponivel = true;
        }

        public bool GetDisponivel()
        {
            return Disponivel;
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public int GetDuracao()
        {
            return Duracao;
        }

        public string GetGenero()
        {
            return Genero;
        }
    }
}
