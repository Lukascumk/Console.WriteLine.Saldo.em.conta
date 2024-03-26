using System;

class Program
{
    public static void Main()
    {

        ContaPF contaPF1 = new ContaPF(nome: "João", cpf: "123.456.789-00", saldo: 1000.0f);

        ContaPJ contaPJ1 = new ContaPJ(nome: "Maria", cnpj: "98765432100", saldo: 5000.0f);

        if (contaPF1.saldo <= 0)
        {
            Console.WriteLine("Saldo insuficiente: " + contaPF1.saldo);
        }
        else
        {
            Console.WriteLine("Saldo: " + contaPF1.saldo);
        }

        if (contaPJ1.saldo >= 0)
        {
            Console.WriteLine("Saldo: " + contaPJ1.saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente: " + contaPJ1.saldo);
        }
    }
}

class ContaPF
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

class ContaPJ
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
