using Estudo_Aprofundamento_POO.Service;

string Opcao;

do
{
    UIService.UiPrincipal();
    Console.Write("O que deseja fazer: ");
    Opcao = Console.ReadLine();

    switch (Opcao)
    {
        case "1":
            UIService.UiAdicionarConta();
            break;

        case "2":
            UIService.UiDepositar();
            break;

        case "3":
            UIService.UiSacar();
            break;
    }
 
}
while (Opcao != "0");
