using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exercicio1Encapsulamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void cmdSalvar_Click(object sender, EventArgs e)
    {
        Funcionario funcionario = new Funcionario();
        funcionario.Nome = txtNome.Text;
        funcionario.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
        funcionario.Salario = Convert.ToDouble(txtSalario.Text);
        funcionario.NumeroFilhos = Convert.ToInt16(txtNFilhos.Text);   
        funcionario.AreaAtuacao = txtAreaAtuacao.Text;
        txtDadosCadastrados.Text = $"{funcionario.Nome} - {funcionario.Salario} - {funcionario.AreaAtuacao}";
    }
}