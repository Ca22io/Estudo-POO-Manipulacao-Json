using Newtonsoft.Json;

namespace App.Models
{
    public class Serie : MidiaBase
    {
        public string? NumeroTemporadas { get; set; }

        public string? EpsodiosVistos { get; set; }


        public Serie(string titulo, string temporada, string epsodio) : base(titulo)
        {
            this.Id = IdGenerator.Next();
            this.NumeroTemporadas = temporada;
            this.EpsodiosVistos = epsodio;
        }

    }
}