namespace ContasPF
{
    public class ContaPF
    {
        public string nome;
        private string cpf;
        private float saldo;

        public ContaPF(string nome, string cpf, float saldo)
        {
            this.nome = nome;
            this.cpf = cpf;
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

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
}