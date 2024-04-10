using System;
using ContasPF;
using ContasPJ;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite Seu Nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite Seu CPF: ");
        string cpf = Console.ReadLine();

        Console.WriteLine("Digite sua Senha: ");
        string senha = Console.ReadLine();

        float saldo = 2000.0f;

        ContaPF contaPF1 = new ContaPF(nome, cpf, senha, saldo);
        Console.WriteLine("Saldo total: " + contaPF1.Saldo);

        Console.WriteLine("Digite o Nome da sua Empresa: ");
        string nomeEmpresa = Console.ReadLine();

        Console.WriteLine("Digite seu CNPJ: ");
        string cnpj = Console.ReadLine();

        Console.WriteLine("Digite a Senha da Empresa: ");
        string senhaEmpresa = Console.ReadLine();

        float saldoEmpresa = 0000.0f;

        ContaPJ ContaPJ1 = new ContaPJ (nomeEmpresa, cnpj, senhaEmpresa, saldoEmpresa);

        //PJ
        if (!senhaEmpresa.All(char.IsDigit) || senhaEmpresa.Length != 6 || saldoEmpresa <=0 || saldoEmpresa >=0 )
        {
            Console.WriteLine("Senha Incorreta");
        }
      else if (senhaEmpresa.All(char.IsDigit) && senhaEmpresa.Length == 6 && saldoEmpresa <=0 && saldoEmpresa >=0)
        {
            Console.WriteLine("Seu Saldo na Sua Conta Pessoa Juridica é : " + ContaPJ1.SaldoEmpresa);
        } 

        //PF 
        if (senha.All(char.IsDigit) || senha.Length != 6 || saldo <=0 || saldo >=0)
        {
            Console.WriteLine("Senha Incorreta");
        }
        else if (senha.All(char.IsDigit) && senha.Length == 6 && saldo <=0 && saldo >= 0)
        {
            Console.WriteLine("Seu Saldo na Sua Conta Pessoa Fisica é : " + contaPF1.Saldo);
        }

        Console.ReadLine();
    }
}