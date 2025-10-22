namespace Estudo_Aprofundamento_POO.Domain
{
    public class Transacao
    {
        public enum TipoTransacao
        {
            Saque,
            Depósito
        }

        public string Valor { get;  protected set; }

        public DateTime DataHora { get;  protected set; }

        public TipoTransacao Tipo { get; protected set; } 

        public Transacao (DateTime Data, TipoTransacao tipo, string valor)
        {
            this.DataHora = Data;
            this.Tipo = tipo;
            this.Valor = valor;
        }
    }
}