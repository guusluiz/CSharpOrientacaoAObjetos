using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        private int numero_agencia;

        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            set { this.numero_agencia = value; }
        }
        public string nome_agencia;
        private double saldo = 100;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}