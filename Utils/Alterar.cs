using App.Models;
using App.Repositories;

namespace App.Utils
{
    public static class Alterar
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("--------- Alteração ---------");
            Console.WriteLine("1- Filme");
            Console.WriteLine("2- Série");
            Console.WriteLine("0- Voltar");
            Console.WriteLine("Qual deseja alterar?");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine(AlterarFilme());
                    Console.WriteLine("Tecle ENTER para continuar!");
                    Console.ReadLine();
                    break;
                
                case "2":
                    Console.WriteLine(AlterarSerie());
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

        private static string? AlterarFilme()
        {
            Console.WriteLine("--------- Atualizar Filme ---------");
            Console.WriteLine("Qual o titulo do filme? ");

            string? titulo = Console.ReadLine();

            if (titulo != null)
            {
                List<MidiaBase> dados = JsonRepositorio.LerArquivo();

                var item = dados.FirstOrDefault(i => i.Titulo == titulo);

                if (item != null)
                {
                    if (item is Filme filmeencontrado)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"Titulo: {filmeencontrado.Titulo?.ToUpper()}");
                        Console.WriteLine($"Deruação: {filmeencontrado.DuracaoMinutos?.ToUpper()} Min");
                        Console.WriteLine("----------------------------");

                        Console.WriteLine("Titulo: ");
                        filmeencontrado.Titulo = Console.ReadLine();

                        Console.WriteLine("Duracao em minutos: ");
                        filmeencontrado.DuracaoMinutos = Console.ReadLine();

                        if (filmeencontrado.Titulo == null || filmeencontrado.DuracaoMinutos == null)
                        {
                            return AlterarFilme();
                        }

                        return JsonRepositorio.SalvarArquivo(dados);
                    }
                    else
                    {
                        return "O item encontrado não é um filme!";
                    }
                }

                return "Midia não encontrada!";
            }
            
            Console.WriteLine("Opção invalida! Tente novamente");
            Console.WriteLine("Tecle ENTER para continuar!");
            Console.ReadLine();
            
            return null;

        }

        private static string? AlterarSerie()
        {
             Console.WriteLine("--------- Atualizar Série ---------");
            Console.WriteLine("Qual o titulo da série? ");

            string? titulo = Console.ReadLine();

            if (titulo != null)
            {
                List<MidiaBase> dados = JsonRepositorio.LerArquivo();

                var item = dados.FirstOrDefault(i => i.Titulo == titulo);

                if (item != null)
                {
                    if (item is Serie serieencontrada)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"Titulo: {serieencontrada.Titulo?.ToUpper()}");
                        Console.WriteLine($"Temporadas: {serieencontrada.NumeroTemporadas}");
                        Console.WriteLine($"Epsódios assistidos: {serieencontrada.EpsodiosVistos}");
                        Console.WriteLine("----------------------------");

                        Console.WriteLine("Titulo: ");
                    serieencontrada.Titulo = Console.ReadLine();

                    Console.WriteLine("Temporadas: ");
                    serieencontrada.NumeroTemporadas = Console.ReadLine();

                    Console.WriteLine("Epsódios asistidos: ");
                    serieencontrada.EpsodiosVistos = Console.ReadLine();

                    if (serieencontrada.Titulo == null || serieencontrada.NumeroTemporadas == null || serieencontrada.EpsodiosVistos == null)
                    {
                        return AlterarSerie();
                    }

                        return JsonRepositorio.SalvarArquivo(dados);
                    }
                    else
                    {
                        return "O item encontrado não é um filme!";
                    }
                }

                return "Midia não encontrada!";
            }
            
            Console.WriteLine("Opção invalida! Tente novamente");
            Console.WriteLine("Tecle ENTER para continuar!");
            Console.ReadLine();

            return null;

        }
    }
}