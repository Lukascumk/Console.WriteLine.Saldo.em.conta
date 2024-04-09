namespace ContasPF
{
    public class ContaPF
    {
        private string nome;
        private string senha;
        private string cpf;
        private float saldo;
    public ContaPF(string nome, string cpf, string senha, float saldo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.senha = senha;
            this.saldo = saldo;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Senha
        {
            get{return senha;}
            set{senha = value;}
        }
        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
      
    }
}