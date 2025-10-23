
namespace Estudo_Aprofundamento_POO.Domain.Contas
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int idCliente, string numero, string agencia, TipoConta tipo) : base(idCliente, numero, agencia, tipo)
        {
        }

        public override void CalcularRendimento()
        {
            this.Saldo += this.Saldo * 0.3;
        }
    }
}