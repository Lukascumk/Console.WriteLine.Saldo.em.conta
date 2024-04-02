using System;
using ContasPF;
using ContasPJ;
class Program
{
    static void Main()
{

Console.WriteLine("Digite Seu Nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite Seu CPF: ");
string cpf = Console.ReadLine();

float saldo = 2000.0f;

ContaPF contaPF2 = new ContaPF(nome, cpf, saldo);
Console.WriteLine("Saldo total: " + contaPF2.Saldo);

ContaPF contaPF1 = new ContaPF(nome: "João", cpf: "123.456.789-00", saldo: 1000.0f);

Console.WriteLine("Digite o Nome da sua Empresa: ");
  string nomeEmpresa = Console.ReadLine();
  
Console.WriteLine("Digite seu CNPJ: ");
  string cnpj = Console.ReadLine();
  
  float saldoEmpresa = 1000.0f;

  ContaPJ ContaPJ2 = new ContaPJ(nomeEmpresa, cnpj, saldoEmpresa);
  Console.WriteLine("Saldo total: " + ContaPJ2.SaldoEmpresa);

  
      ContasPJ.ContaPJ contaPJ1 = new ContasPJ.ContaPJ
      (nomeEmpresa: "Maria", cnpj: "98765432100", saldoEmpresa: 5000.0f);
        if (contaPF1.Saldo <= 0)
        {
            Console.WriteLine("Saldo insuficiente: " +contaPF1.Saldo);
        }
        else
        {
            Console.WriteLine("Saldo: " +contaPF1.Saldo);
        }
        if (contaPJ1.SaldoEmpresa >= 0)
        {
            Console.WriteLine("Saldo: " +contaPJ1.SaldoEmpresa);
        }
        else
        {
        Console.WriteLine("Saldo insuficiente: " +contaPJ1.SaldoEmpresa);
        }

        Console.ReadLine();
    }
}