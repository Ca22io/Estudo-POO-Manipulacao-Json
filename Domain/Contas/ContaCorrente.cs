namespace Estudo_Aprofundamento_POO.Domain.Contas
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int idCliente, string numero, string agencia) : base(idCliente, numero, agencia)
        {
        }

        public override void CalcularRendimento()
        {
            throw new NotImplementedException();
        }
    }
}