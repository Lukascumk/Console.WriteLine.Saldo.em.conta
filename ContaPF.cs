using System;
using System.Linq;

namespace ContasPF
{

  public class ContaPF
  {
    private string nome;
    private string cpf;
    private string senha;
    private float saldo;

    public ContaPF(string nome, string cpf, string senha, float saldo)
    {
        this.nome = nome;
        this.cpf = cpf;
        SetSenha(senha);
        this.saldo = saldo;
    }

    private bool ValorNumerico(string valor)
    {
        return valor.All(char.IsDigit);
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string CPF
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public string Senha
    {
        get { return senha; }
        private set { senha = value; }
    }

    public void SetSenha(string value)
    {
        if (value.Length != 6)
        {
            throw new ArgumentException("A Senha deve conter apenas 6 dígitos");
        }
        if (!ValorNumerico(value))
        {
            throw new ArgumentException("A Senha deve conter apenas números");
        }

        Senha = value;
    }

    public float Saldo
    {
        get { return saldo; }
        set { saldo = value; }
    }
  }
}