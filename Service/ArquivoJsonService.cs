using Newtonsoft.Json.Linq;

namespace Estudo_Aprofundamento_POO.Service
{
    public class ArquivoJsonService : IArquivoJsonService
    {
        private string CaminhoDoArquivo = "dados.json";

        public JArray LerArquivo()
        {
            string json = File.ReadAllText(CaminhoDoArquivo);

            JArray arquivo = JArray.Parse(json);

            return arquivo;
        }

        public string SalvarArquivo(JArray dados)
        {
            try
            {
                File.WriteAllText(CaminhoDoArquivo, dados.ToString());

                return "Dados Salvos com sucesso!";
            }
            catch (Exception ex)
            {
                return $"Ocorreu um erro não tratado. Detalhes do erro: {ex}";
            }
            
        }
    }
}