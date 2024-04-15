using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Empregado
/// </summary>
public class Empregado
{
    private string nome;
    private string cpf;
    private double salario;
    public Empregado()
    {
       
    }

    public string Nome { get => nome; set => nome = value; }
    public string Cpf { get => cpf; set => cpf = value; }
    public double Salario { get => salario; set => salario = value; }
}