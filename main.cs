using System;
using ContasPF;
using ContasPJ;

class Program
{
    public static void Main()
    {

      
      
      ContasPF.ContaPF contaPF1 = new ContaPF
      (nome: "João", cpf: "123.456.789-00", saldo: 1000.0f);
        
      ContasPJ.ContaPJ contaPJ1 = new ContasPJ.ContaPJ
      (nome: "Maria", cnpj: "98765432100", saldo: 5000.0f);

      
        if (contaPF1.Saldo <= 0)
        {
            Console.WriteLine("Saldo insuficiente: " + contaPF1.Saldo);
        }
        else
        {
            Console.WriteLine("Saldo: " + contaPF1.Saldo);
        }

        if (contaPJ1.saldo >= 0)
        {
            Console.WriteLine("Saldo: " + contaPJ1.saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente: " + contaPJ1.saldo);
        }

        Console.ReadLine();
    }
}