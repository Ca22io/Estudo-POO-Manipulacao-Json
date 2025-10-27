using Newtonsoft.Json;

namespace App.Models
{
    public class Serie : MidiaBase
    {
        public string NumeroTemporadas { get; private set; }

        public string EpsodiosVistos { get; private set; }


        public Serie(string titulo, string temporada, string epsodio) : base(titulo)
        {
            this.NumeroTemporadas = temporada;
            this.EpsodiosVistos = epsodio;
        }

         public static string Serealizar(Serie serie)
        {
            return JsonConvert.SerializeObject(serie);
        }
        
        public static Serie Desserializar (string serie)
        {
            return JsonConvert.DeserializeObject<Serie>(serie);
        }
    }
}