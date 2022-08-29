using ByteBank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private String _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {

                }
                else
                {
                    _conta = value;
                }
            }
        }

        public String NomeAgencia { get; set; }

        private int _numero_agencia;
        public int Agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }

        private double saldo;


        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0) { return false; }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor) { return false; }
            if (valor < 0) { return false; }
            else
            {
                saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo = valor;
            }
        }

        public string GetSaldo()
        {
            return "Seu saldo atual é de R$" + saldo;
        }

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }


        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            Agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas++;
        }

        public static int TotalDeContasCriadas { get; set; }

    }
}