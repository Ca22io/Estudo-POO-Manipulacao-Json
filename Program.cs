
using App.Models;
using App.Repositories;

var carregar = JsonRepositorio.LerArquivo();

var teste = new Filme("Filme de teste");

carregar.Add(teste);

// var teste = carregar.FirstOrDefault(x => x.Titulo == "Filme de teste");

Console.WriteLine(JsonRepositorio.SalvarArquivo(carregar));