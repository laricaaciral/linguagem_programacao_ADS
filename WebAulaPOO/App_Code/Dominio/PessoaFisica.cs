using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PessoaFisica
/// </summary>
public class PessoaFisica:Pessoa
{
    private string cpf;
    private string rg;
    private DateTime dataNascimento;
    public PessoaFisica()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string Cpf { get => cpf; set => cpf = value; }
    public string Rg { get => rg; set => rg = value; }
    public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
}