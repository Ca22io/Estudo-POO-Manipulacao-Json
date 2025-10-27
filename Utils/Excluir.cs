using App.Repositories;

namespace App.Utils
{
    public static class Excluir
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("--------- Exclusão ---------");
            Console.WriteLine("Qual o título da midia que deseja excluir?");
            string? titulo = Console.ReadLine();

            if (titulo != null)
            {
                Console.WriteLine(Exclusao(titulo));
                Console.WriteLine("Tecle ENTER para continuar!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Valor invalido! Tente novamente");
                Console.WriteLine("Tecle ENTER para continuar!");
                Console.ReadLine();

                Mostrar();  
            }
        }

        private static string Exclusao(string titulo)
        {
            var dados = JsonRepositorio.LerArquivo();

            var localizar = dados.FirstOrDefault(i => i.Titulo == titulo.ToUpper());

            if (localizar == null)
            {
                return "Midia não encontrada!";
            }

            dados.Remove(localizar);

            return JsonRepositorio.SalvarArquivo(dados);
        }
    }
}