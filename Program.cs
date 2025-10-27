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
        case "2":
            Alterar.Mostrar();
            break;
        case "3":
            Excluir.Mostrar();
            break;
        case "4":
            Exibir.Mostrar();
            break;
    }
}
while (opcao != "0");