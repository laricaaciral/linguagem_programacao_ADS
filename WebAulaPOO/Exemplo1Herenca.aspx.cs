using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exemplo1Herenca : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void cmdCadastrar_Click(object sender, EventArgs e)
    {
        Gerente gerente = new Gerente();
        gerente.Nome = txtNome.Text;
        gerente.Cpf = txtCPF.Text;
        gerente.Salario= Convert.ToDouble(txtSalario.Text);
        gerente.Senha = txtSenha.Text;

        txtDadosCadastrados.Text = $"O gerente {gerente.Nome} cujo CPF é {gerente.Cpf}, recebe um salário de R${gerente.Salario}. ";
    }
}