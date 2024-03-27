namespace ContasPF
{
    public class ContaPF
    {
        public string nome;
        public string cpf;
        public float saldo;

        public ContaPF(string nome, string cpf, float saldo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.saldo = saldo;
        }
    }
}