using App.Models;
using App.Repositories;

namespace App.Utils
{
    public static class Cadastrar
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("--------- Cadastro ---------");
            Console.WriteLine("1- Filme");
            Console.WriteLine("2- Série");
            Console.WriteLine("0- Voltar");
            Console.WriteLine("Qual deseja cadastrar?");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine(CadastrarFilme());
                    Console.WriteLine("Tecle ENTER para continuar!");
                    Console.ReadLine();
                    break;
                
                case "2":
                    Console.WriteLine(CadastrarSerie());
                    Console.WriteLine("Tecle ENTER para continuar!");
                    Console.ReadLine();
                    break;
                
                case "0":
                    break;

                default:
                    Console.WriteLine("Opção invalida! Tente novamente");
                    Console.WriteLine("Tecle ENTER para continuar!");
                    Console.ReadLine();
                    Mostrar();
                    break;
            }
        }

        private static string CadastrarFilme()
        {
            Console.WriteLine("--------- Cadastro de Filme ---------");
            Console.WriteLine("Titulo: ");
            string? titulo = Console.ReadLine();

            Console.WriteLine("Duracao em minutos: ");
            string? duracao = Console.ReadLine();

            if (titulo == null || duracao == null)
            {
                return CadastrarFilme();
            }

            Filme filme = new Filme(titulo.ToUpper(), duracao);

            List<MidiaBase> json = JsonRepositorio.LerArquivo();

            json.Add(filme);

            return JsonRepositorio.SalvarArquivo(json);

        }

        private static string CadastrarSerie()
        {
            Console.WriteLine("--------- Cadastro de Série ---------");
            Console.WriteLine("Titulo: ");
            string? titulo = Console.ReadLine();

            Console.WriteLine("Temporadas: ");
            string? temporadas = Console.ReadLine();

            Console.WriteLine("Epsodios asistidos: ");
            string? epsodiosasistidos = Console.ReadLine();

            if (titulo == null || temporadas == null || epsodiosasistidos == null)
            {
                return CadastrarSerie();
            }

            Serie serie = new Serie(titulo.ToUpper(), temporadas, epsodiosasistidos.ToUpper());

            List<MidiaBase> json = JsonRepositorio.LerArquivo();

            json.Add(serie);

            return JsonRepositorio.SalvarArquivo(json);

        }
    }
}