namespace Estudo_Aprofundamento_POO.Domain
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public required string CPF { get; set; }
        public required string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
    }
}