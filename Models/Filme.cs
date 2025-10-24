namespace App.Models
{
    public class Filme : MidiaBase
    {
        public string DuracaoMinutos { get; set; }


        public Filme(string titulo, string duracao) : base(titulo)
        {
            this.DuracaoMinutos = duracao;
        }
    }
}