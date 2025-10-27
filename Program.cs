
using App.Utils;

string opcao;

do
{
    Console.Clear();
    Menu.Mostrar();

    opcao = Menu.EscolherOpcao();

    switch(opcao)
    {
        case "1":
            Cadastrar.Mostrar();
            break;
    }
}
while (opcao != "0");
    