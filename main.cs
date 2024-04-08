using System;
using ContasPF;
using ContasPJ;
using Transacao;

class Program
{
      static void Main()
    {
      Console.WriteLine("Digite Seu Nome: ");
      string nome = Console.ReadLine();

      Console.WriteLine("Digite Seu CPF: ");
      string cpf = Console.ReadLine();

      float saldo = 2000.0f;

      ContaPF contaPF1 = new ContaPF(nome, cpf, saldo);
      Console.WriteLine("Saldo total: " + contaPF1.Saldo);


Console.WriteLine("Digite o Nome da sua Empresa: ");
  string nomeEmpresa = Console.ReadLine();
  
Console.WriteLine("Digite seu CNPJ: ");
  string cnpj = Console.ReadLine();
  
  float saldoEmpresa = 1000.0f;
  
ContaPJ ContaPJ1 = new ContaPJ(nomeEmpresa, cnpj, saldoEmpresa);
Console.WriteLine("Saldo total: " + ContaPJ1.SaldoEmpresa);

  
   
        if (contaPF1.Saldo <= 0)
        {
            Console.WriteLine("Saldo insuficiente: " +contaPF1.Saldo);
        }
        else
        {
            Console.WriteLine("Saldo: " +contaPF1.Saldo);
        }
        if (ContaPJ1.SaldoEmpresa >= 0)
        {
            Console.WriteLine("Saldo: " +ContaPJ1.SaldoEmpresa);
        }
        else
        {
        Console.WriteLine("Saldo insuficiente: " +ContaPJ1.SaldoEmpresa);
        }

        Console.ReadLine();
    }
}