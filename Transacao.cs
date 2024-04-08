namespace Transacao
{

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
      public SaldoConta(float saldoF)
      {
          this.saldoF = saldoF;
      }
      public SaldoConta(int saldoI)
      {
          this.saldoI = saldoI;
      }
      public SaldoConta(decimal saldoD)
      {
          this.saldoD = saldoD;
      }
    
      public void mesmoSaldo(float valor)
      {
          if (saldoF - valor <=0){
              Console.WriteLine("Compra Negada");
          }
          else
        {
              TransacaoConta transacaoConta = new TransacaoConta("debito", "credito", "pix");
              Console.WriteLine("Saldo atual:  {saldo}"+transacaoConta.saldoConta);
          }
      }
  }


  public class TransacaoConta
  {
      public string debito;
      public string credito;
      public string pix;
      public float saldoConta; 
      public TransacaoConta(string debito, string credito, string pix)
      {
          this.debito = debito;
          this.credito = credito;
          this.pix = pix;
          this.saldoConta = 0.0f;
      }
      public void Debitar(float valor)
      {
          saldoConta -= valor;
      }
      public void Credito(float valor)
      {
          saldoConta += valor;
      }
      public void Pix(float valor)
      {
          saldoConta -= valor;
      }
  }
}