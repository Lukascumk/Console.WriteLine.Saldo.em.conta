namespace ContasPJ
{
    public class ContaPJ
    {
        public string nome;
        public string cnpj;
        public float saldo;

        public ContaPJ(string nome, string cnpj, float saldo)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.saldo = saldo;
        }
    }
}