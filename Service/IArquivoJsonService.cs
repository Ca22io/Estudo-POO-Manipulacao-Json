using Newtonsoft.Json.Linq;

namespace Estudo_Aprofundamento_POO.Service
{
    public interface IArquivoJsonService
    {
        public JArray LerArquivo();

        public string SalvarArquivo(JArray dados);

    }
}