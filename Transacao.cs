namespace Transacao
{
    public class TransacaoConta
    {
        public string debito;
        public string credito;
        public string pix;

        public TransacaoConta(string debito, string credito, string pix)
        {
            this.debito = debito;
            this.credito = credito;
            this.pix = pix;
        }
    public class SaldoConta
    {
        public float saldoF;
        public int saldoI;
        public decimal saldoD;

        public SaldoConta(float saldoF, int saldoI, decimal saldoD)
        {
            this.saldoF = saldoF;
            this.saldoI = saldoI;
            this.saldoD = saldoD;
        }

        public void AdicionarSaldo(float valor)
        {
            saldoF += valor;
        }

        public void SubtrairSaldo(float valor)
        {
            saldoF -= valor;
        }
      
    }
  
  }
  
}