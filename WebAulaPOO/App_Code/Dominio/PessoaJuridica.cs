using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PessoaJuridica
/// </summary>
public class PessoaJuridica:Pessoa
{
    private string cnpj;
    private string inscrEstradual;
    private string inscrMunicipal;
    public PessoaJuridica()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string Cnpj { get => cnpj; set => cnpj = value; }
    public string InscrEstradual { get => inscrEstradual; set => inscrEstradual = value; }
    public string InscrMunicipal { get => inscrMunicipal; set => inscrMunicipal = value; }
}