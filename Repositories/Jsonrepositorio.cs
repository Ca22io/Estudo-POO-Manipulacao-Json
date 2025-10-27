using App.Models;
using Newtonsoft.Json;

namespace App.Repositories
{
    public class JsonRepositorio : IJsonRespositorio
    {
        private static string CaminhoDoArquivo { get; } = "../../../data/dados.json";

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.Objects
        };

        public static List<MidiaBase> LerArquivo()
        {

            if (!Directory.Exists("../../../data"))
            {
                Directory.CreateDirectory("../../../data");
            }

            if (!File.Exists(CaminhoDoArquivo))
            {
                File.WriteAllText(CaminhoDoArquivo, "[]");
            }

            string json = File.ReadAllText(CaminhoDoArquivo);

            if (json.Length <= 0)
            {
                return new List<MidiaBase>();
            }

            var dados = JsonConvert.DeserializeObject<List<MidiaBase>>(json, Settings);

            return dados;

        }

        public static string SalvarArquivo(List<MidiaBase> dados)
        {
            try
            {
                var serializar = JsonConvert.SerializeObject(dados, Settings);

                File.WriteAllText(CaminhoDoArquivo, serializar);

                return "Dados Salvos com sucesso!";
            }
            catch (Exception ex)
            {
                return $"Ocorreu um erro não tratado. Detalhes do erro: {ex}";
            }
            
        }

        public static MidiaBase ObterItem(string titulo)
        {
            var dados = LerArquivo();

            return dados.FirstOrDefault(i => i.Titulo == titulo);

        }
    }
} 