using System;
using System.Linq;

namespace ContasPJ
{
    public class ContaPJ
    {
        private string nomeEmpresa;
        private string cnpj;
        private string senhaEmpresa;
        private float saldoEmpresa;
        public ContaPJ(string nomeEmpresa, string cnpj, string senhaEmpresa, float saldoEmpresa)
        {
            this.nomeEmpresa = nomeEmpresa;
            this.cnpj = cnpj;
            this.senhaEmpresa = senhaEmpresa;
            this.saldoEmpresa = saldoEmpresa;
        }
      private bool ValorNumerico(string valor)
      {
          return valor.All(char.IsDigit);
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

        public string SenhaEmpresa
        {
            get { return senhaEmpresa; }
            set
            {
                if (value.Length != 6)
                {
                    throw new ArgumentException("A Senha deve conter apenas 6 dígitos");
                }
                if (!ValorNumerico(value))
                {
                    throw new ArgumentException("A Senha deve conter apenas números");
                }
                senhaEmpresa = value;
            }
        }
      public float SaldoEmpresa
                {
                  get { return saldoEmpresa; }
                  set { saldoEmpresa = value;}
        
                }
    }
}