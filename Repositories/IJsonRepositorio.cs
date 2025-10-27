using App.Models;

namespace App.Repositories
{
    public interface IJsonRespositorio
    {
        abstract static List<MidiaBase> LerArquivo();

        abstract static string SalvarArquivo(List<MidiaBase> dados);

        abstract static MidiaBase ObterItem(string titulo);

    }
}