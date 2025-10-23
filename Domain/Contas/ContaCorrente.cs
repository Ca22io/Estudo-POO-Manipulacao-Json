namespace Estudo_Aprofundamento_POO.Domain.Contas
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int idCliente, string numero, string agencia, TipoConta tipo) : base(idCliente, numero, agencia, tipo)
        {
        }

        public override void CalcularRendimento()
        {
            throw new NotImplementedException();
        }
    }
}