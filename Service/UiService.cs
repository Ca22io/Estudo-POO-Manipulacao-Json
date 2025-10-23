using Estudo_Aprofundamento_POO.Domain;
using Estudo_Aprofundamento_POO.Domain.Contas;

namespace Estudo_Aprofundamento_POO.Service
{
    public class UIService : IUiService
    {
        public static void UiAdicionarConta()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("    CADASTRO DE NOVA CONTA BANCÁRIA     ");
            Console.WriteLine("========================================");
            Console.WriteLine();

            try
            {
                Console.WriteLine("--- Dados do Cliente ---");
                Console.Write("Digite o CPF do cliente (apenas números): ");
                string cpf = Console.ReadLine();

                Console.Write("Digite o Nome Completo do cliente: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a Data de Nascimento (DD/MM/AAAA): ");
                string dataNascimento = Console.ReadLine();

                Cliente cliente = new Cliente
                {
                    CPF = cpf,
                    Nome = nome,
                    DataNascimento = DateOnly.ParseExact(dataNascimento, "dd-MM-yyyy")
                };

                cliente.IdCliente = Cliente.GerarId();

                Console.WriteLine();
                Console.WriteLine("--- Dados da Conta ---");

                Console.Write("Digite o número da Agência (ex: 0001): ");
                string agencia = Console.ReadLine();

                Console.Write("Digite o número da Conta (ex: 12345-6): ");
                string numeroConta = Console.ReadLine();

                Console.WriteLine("Qual o tipo da conta?");
                Console.WriteLine("  [1] - Conta Corrente");
                Console.WriteLine("  [2] - Conta Poupança");
                Console.Write("Digite sua opção (1 ou 2): ");
                string tipoContaOpcao = Console.ReadLine();

                if (tipoContaOpcao == "1")
                {
                    ContaCorrente conta = new ContaCorrente
                    {
                        Agencia = agencia,
                        Numero = 1223122,


                    };
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"SUCESSO: {tipo} (Nº {numeroConta}) criada para o cliente {nome}.");
                Console.ResetColor();

                PausarEVoltar();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERRO AO CRIAR CONTA: {ex.Message}");
                Console.ResetColor();
                
                PausarEVoltar();
            }
        }

        public static void UiDepositar()
        {
            throw new NotImplementedException();
        }

        public static void UiPrincipal()
        {
            Console.WriteLine("Teste");
        }

        public static void UiSacar()
        {
            throw new NotImplementedException();
        }

        private static void PausarEVoltar()
        {
            Console.WriteLine("\nPressione [Enter] para voltar ao menu principal...");
            Console.ReadLine();
        }
    }
}