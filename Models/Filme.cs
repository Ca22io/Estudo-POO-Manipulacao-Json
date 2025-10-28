using Newtonsoft.Json;

namespace App.Models
{
    public class Filme : MidiaBase
    {
        public string? DuracaoMinutos { get; set; }


        public Filme(string titulo, string duracao) : base(titulo)
        {
            this.Id = IdGenerator.Next();
            this.DuracaoMinutos = duracao;
        }
    }
}