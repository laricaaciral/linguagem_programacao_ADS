using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Funcionario
/// </summary>
public class Funcionario
{
    private string nome;
    private DateTime dataNascimento;
    private double salario;
    private int numeroFilhos;
    private string areaAtuacao;

    public Funcionario()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string Nome { get => nome; set => nome = value; }
    public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    public double Salario { get => salario; set => salario = value; }
    public int NumeroFilhos { get => numeroFilhos; set => numeroFilhos = value; }
    public string AreaAtuacao { get => areaAtuacao; set => areaAtuacao = value; }
}