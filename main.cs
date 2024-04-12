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

      try
      {
          ContaPF contaPF1 = new ContaPF(nome, cpf, senha, saldo);
          Console.WriteLine("O Saldo da sua conta Pessoa Física é: " + contaPF1.Saldo);
      }
      catch (ArgumentException ex)
      {
          Console.WriteLine("Senha Incorreta para " + nome + ": " + ex.Message);
      }

      try
      {
          ContaPJ ContaPJ1 = new ContaPJ(nomeEmpresa, cnpj, senhaEmpresa, saldoEmpresa);
          Console.WriteLine("O Saldo da Sua Conta Pessoa Jurídica é: " + ContaPJ1.SaldoEmpresa);
      }
      catch (ArgumentException ex)
      {
          Console.WriteLine("Senha Incorreta para " + nomeEmpresa + ": " + ex.Message);
      }


        Console.ReadLine();
    }
}
