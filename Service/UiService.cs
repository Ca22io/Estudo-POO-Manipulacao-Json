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

                // -----------------------------------------------------------------
                // AQUI VOCÊ DEVE CHAMAR SEUS SERVIÇOS DE APLICAÇÃO
                // (Ex: clienteService.CriarOuBuscarCliente(...), contaService.CriarConta(...))
                // -----------------------------------------------------------------

                // Exemplo de como a lógica de chamada seria:
                /*
                
                // 1. Validações simples (faça validações melhores nos seus serviços)
                if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(agencia) || string.IsNullOrEmpty(numeroConta))
                {
                    throw new Exception("Todos os campos são obrigatórios.");
                }

                // 2. (Simulação) Chama os serviços para criar as entidades
                // Cliente novoCliente = clienteService.CriarCliente(cpf, nome, dataNascimento);
                
                string tipoDescricao;
                
                if (tipoContaOpcao == "1")
                {
                    // contaService.CriarContaCorrente(novoCliente.Id, numeroConta, agencia);
                    tipoDescricao = "Conta Corrente";
                }
                else if (tipoContaOpcao == "2")
                {
                    // A Poupança precisa da taxa, vamos definir uma padrão por enquanto
                    float taxaPadrao = 0.005f; // 0.5%
                    // contaService.CriarContaPoupanca(novoCliente.Id, numeroConta, agencia, taxaPadrao);
                    tipoDescricao = "Conta Poupança";
                }
                else
                {
                    throw new Exception("Tipo de conta inválido.");
                }
                */

                // -----------------------------------------------------------------
                // 4. Mensagem de Sucesso (simulada)
                // Remova a linha abaixo quando implementar a lógica real
                string tipoDescricao = (tipoContaOpcao == "1") ? "Conta Corrente" : "Conta Poupança";
                // -----------------------------------------------------------------

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"SUCESSO: {tipoDescricao} (Nº {numeroConta}) criada para o cliente {nome}.");
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