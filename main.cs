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

        float saldoEmpresa = 1000.0f;

        ContaPJ ContaPJ1 = new ContaPJ (nomeEmpresa, cnpj, senhaEmpresa, saldoEmpresa);

        if (!senhaEmpresa.All(char.IsDigit) || senhaEmpresa.Length != 6)
        {
            Console.WriteLine("Senha Incorreta");
        }
        else
        {
            Console.WriteLine("Seu Saldo na Sua Conta Pessoa Juridica é : " + ContaPJ1.SaldoEmpresa);
        }

        if (contaPF1.Saldo <= 0)
        {
            Console.WriteLine("Saldo insuficiente em sua conta Pessoa Física: " + contaPF1.Saldo);
        }
        else
        {
            Console.WriteLine("Saldo da sua conta Pessoa Física é: " + contaPF1.Saldo);
        }

        if (senhaEmpresa.All(char.IsDigit) && senhaEmpresa.Length == 6)
        {
            Console.WriteLine("Saldo de Sua Conta Pessoa Juridíca: " + ContaPJ1.SaldoEmpresa);
        }
        else
        {
            if (!senhaEmpresa.All(char.IsDigit))
            {
                Console.WriteLine("Senha Incorreta! Digite apenas números");
            }
            else if (senhaEmpresa.Length != 6)
            {
                Console.WriteLine("A Senha deve conter apenas 6 dígitos");
            }
        }

        Console.ReadLine();
    }
}