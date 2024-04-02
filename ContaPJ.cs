namespace ContasPJ
{
    public class ContaPJ
    {
        private string nomeEmpresa;
        private string cnpj;
        private float saldoEmpresa;
      public ContaPJ  
      (string nomeEmpresa, string cnpj, float saldoEmpresa)
        {
            this.nomeEmpresa = nomeEmpresa;
            this.cnpj = cnpj;
            this.saldoEmpresa = saldoEmpresa;
        }
              public string NomeEmpresa
              {
                  get { return nomeEmpresa; }
                  set { nomeEmpresa = value; }
              }
              public string CNPJ
              {
                  get { return cnpj; }
                  set { cnpj = value; }
              }
              public float SaldoEmpresa
              {
                  get { return saldoEmpresa; }
                  set { saldoEmpresa = value; }
              }
    }
}