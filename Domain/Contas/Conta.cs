namespace Estudo_Aprofundamento_POO.Domain.Contas
{
    public abstract class Conta : IConta
    {
        public enum TipoConta
        {
            Corrente,
            Poupanca
        }

        public int IdCliente { get; private set; }
        public TipoConta Tipo {get; private set;}
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public List<Transacao> Transacoes { get; private set; }
        public double Saldo { get; protected set; }

        protected Conta(int idCliente, string numero, string agencia, TipoConta tipo)
        {
            this.IdCliente = idCliente;
            this.Numero = numero;
            this.Agencia = agencia;
            this.Saldo = 0;
            this.Tipo = tipo;
            this.Transacoes = new List<Transacao>();
        }

        protected Conta(int idCliente, string numero, string agencia)
        {
            IdCliente = idCliente;
            Numero = numero;
            Agencia = agencia;
        }

        public virtual string Depositar(float valor)
        {
            if (valor <= 0)
            {
                return "Erro: O valor do depósito deve ser positivo.";
            }

            this.Saldo += valor;
            this.Transacoes.Add(new Transacao(DateTime.Now, Transacao.TipoTransacao.Depósito, valor.ToString()));
            
            return $"Depósito de R$ {valor} realizado. Novo saldo: R$ {this.Saldo}";
        }

        public virtual string Sacar(float valor)
        {
            if (valor <= 0)
            {
                return "Erro: O valor do saque deve ser positivo.";
            }
            if (this.Saldo < valor)
            {
                return "Erro: Saldo insuficiente.";
            }

            this.Saldo -= valor;
                this.Transacoes.Add(new Transacao(DateTime.Now, Transacao.TipoTransacao.Saque, valor.ToString($"-{valor}")));
            
            return $"Saque de R$ {valor} realizado. Novo saldo: R$ {this.Saldo}";
        }

        public virtual string VerExtrato()
        {
            var extrato = new System.Text.StringBuilder();
            extrato.AppendLine($"--- Extrato Conta {this.Numero} / Ag. {this.Agencia} ---");
            extrato.AppendLine("Data\t\t\tTipo\t\tValor");
            
            foreach (var transacao in this.Transacoes)
            {
                extrato.AppendLine(transacao.ToString());
            }
            
            extrato.AppendLine("-------------------------------------------------");
            extrato.AppendLine($"SALDO ATUAL: R$ {this.Saldo}");
            
            return extrato.ToString();
        }

        public abstract void CalcularRendimento();

    }
}