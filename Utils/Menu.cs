namespace App.Utils
{
    public static class Menu
    {
        public static void Mostrar()
        {
            Console.WriteLine("---------- Menu ----------");
            Console.WriteLine("1- Cadastrar");
            Console.WriteLine("2- Alterar");
            Console.WriteLine("3- Excluir");
            Console.WriteLine("4- Exibir todos");
            Console.WriteLine("0- Sair");
        }

        public static string EscolherOpcao()
        {
            Console.Write("O que deseja fazer: ");
            string? opcao = Console.ReadLine();

            if (opcao != null)
            {
                return opcao.Length > 0 ? opcao : "0";
            }

            return "0";
        }
    }
}