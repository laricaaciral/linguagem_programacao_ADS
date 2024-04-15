using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Gerente
/// </summary>
public class Gerente:Empregado
{
    private string senha;
    public Gerente()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string Senha { get => senha; set => senha = value; }
    public bool Autenticar(string senha)
    {
        return true;
    }
}