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

       

        Console.WriteLine("Digite o Nome da sua Empresa: ");
        string nomeEmpresa = Console.ReadLine();

        Console.WriteLine("Digite seu CNPJ: ");
        string cnpj = Console.ReadLine();

        Console.WriteLine("Digite a Senha da Empresa: ");
        string senhaEmpresa = Console.ReadLine();

        float saldoEmpresa = 0000.0f;

        ContaPJ ContaPJ1 = new ContaPJ (nomeEmpresa, cnpj, senhaEmpresa, saldoEmpresa);
        ContaPF contaPF1 = new ContaPF(nome, cpf, senha, saldo);
      

        
      if ((!senhaEmpresa.All(char.IsDigit) || senhaEmpresa.Length != 6) ||
          (!senha.All(char.IsDigit) || senha.Length != 6))
      {
          Console.WriteLine("Senha Incorreta");
        
        
      }
        else
        {
            Console.WriteLine("Seu Saldo na Sua Conta Pessoa Jurídica é: " + ContaPJ1.SaldoEmpresa ); 
          Console.WriteLine("Seu Saldo na Sua Conta Pessoa Física é: " + contaPF1.Saldo);
        }

        Console.ReadLine();
    }
}
