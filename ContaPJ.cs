namespace ContasPJ
{
    public class ContaPJ
    {
        private string nomeEmpresa;
        private string cnpj;
        private string senha;

        public ContaPJ(string nomeEmpresa, string cnpj, string senha)
        {
            this.nomeEmpresa = nomeEmpresa;
            this.cnpj = cnpj;
            this.senha = senha;
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

        public string Senha
        {
            get { return senha; }
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
                senha = value;
            }
        }

        private bool ValorNumerico(string valor)
        {
            return valor.All(char.IsDigit);
        }
    }
}