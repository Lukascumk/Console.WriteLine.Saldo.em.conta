namespace Transacao
{
    public class SaldoConta
    {
        public float saldoF;
        public int saldoI;
        public decimal saldoD;
        public TransacaoConta TransacaoConta;

        public SaldoConta(float saldoF, int saldoI, decimal saldoD)
        {
            this.saldoF = saldoF;
            this.saldoI = saldoI;
            this.saldoD = saldoD;
            this.TransacaoConta = new TransacaoConta();
        }


        public class TransacaoConta
        {
            public string debito;
            public string credito;
            public string pix;

            public void RealizarDebito(float valor)
            {
                this.saldof -= valor;
                this.saldoI -= valor;
                this.saldoD -= valor;
            }


            public void RealizarCredito(float valor)
            {
                this.saldof -= valor;
                this.saldoI -= valor;
                this.saldoD -= valor;
            }

            public void RealizarPix(float valor)
            {
                if (this.saldo > 0)
                {
                    saldo += valor;
                    Console.WriteLine($"Transação de {valor:c} Realizada. Novo saldo: {saldo:c}");
                }
                else if (valor < 0)
                {
                    saldo -= Math.Abs(valor);
                    Console.WriteLine($"Transação de {valor:c} realizada. Novo saldo:{saldo:c}");
                }
                else
                {
                    Console.WriteLine("Trasação negada.");
                }
            }
            public TransacaoConta(string debito, string credito, string pix)
            {
                this.debito = debito;
                this.credito = credito;
                this.pix = pix;
            }