using App.Models;
using App.Repositories;

namespace App.Utils
{
    public static class Exibir
    {
        public static void Mostrar()
        {
            Console.Clear();

            var dados = JsonRepositorio.LerArquivo();

            if (dados.Count <= 0)
            {
                Console.WriteLine("Não possui midia cadastrada.");
            }

            foreach (var item in dados)
            {
                if (item is Filme filme)
                {
                    Console.WriteLine("--------- Filme ---------");
                    Console.WriteLine($"Titulo: {filme.Titulo?.ToUpper()}");
                    Console.WriteLine($"Deruação: {filme.DuracaoMinutos?.ToUpper()} Min");
                }
                else if (item is Serie serie)
                {
                    Console.WriteLine("--------- Série ---------");
                    Console.WriteLine($"Titulo: {serie.Titulo?.ToUpper()}");
                    Console.WriteLine($"Temporadas: {serie.NumeroTemporadas}");
                    Console.WriteLine($"Epsódios assistidos: {serie.EpsodiosVistos}");

                }
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Tecle ENTER para continuar!");
            Console.ReadLine();
        }
    }
}
