using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pessoa
/// </summary>
public class Pessoa
{
    private string nome;
    private string endereco;
    private string telefone;

    public Pessoa()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string Nome { get => nome; set => nome = value; }
    public string Endereco { get => endereco; set => endereco = value; }
    public string Telefone { get => telefone; set => telefone = value; }

    public double calcImpostoDeRenda()
    {
        return 0.0;
    }
}