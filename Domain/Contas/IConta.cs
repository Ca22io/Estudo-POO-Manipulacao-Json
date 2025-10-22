namespace Estudo_Aprofundamento_POO.Domain.Contas
{
    public interface IConta
    {
        public string Sacar(float Valor);
        public string Depositar(float Valor);
        public string VerExtrato();
        abstract void CalcularRendimento();
    }
}