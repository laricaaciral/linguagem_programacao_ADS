using Microsoft.AspNetCore.Mvc;
using WebAPIVendasTurmaB.Dominio;

namespace WebAPIVendasTurmaB.Controllers
{
    public class FuncionarioController : ControllerBase
    {
        [HttpPost("Adicionar Funcionario")]
        public ActionResult<Funcionario> Adicionar(Funcionario funcionarioTela )
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome= funcionarioTela.Nome;
            funcionario.Cpf= funcionarioTela.Cpf;
            funcionario.Email= funcionarioTela.Email;
            funcionario.Cargo= funcionarioTela.Cargo;
            funcionario.Salario= funcionarioTela.Salario;
            funcionario.DataAdmissao = funcionarioTela.DataAdmissao;
            funcionario.Adicionar();

            return funcionario;
        }

        [HttpPut("Alterar Funcionario")]
        public ActionResult<Funcionario> Alterar(Funcionario funcionarioTela)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = funcionarioTela.Nome;
            funcionario.Cpf = funcionarioTela.Cpf;
            funcionario.Email = funcionarioTela.Email;
            funcionario.Cargo = funcionarioTela.Cargo;
            funcionario.Salario = funcionarioTela.Salario;
            funcionario.DataAdmissao = funcionarioTela.DataAdmissao;
            funcionario.Alterar(funcionarioTela.Id);

            return funcionario;
        }

        [HttpDelete("Excluir Funcionario")]
        public ActionResult<Funcionario> Excluir(int idFuncionario)
        {
            Funcionario funcionario = new Funcionario();           
            funcionario.Excluir(idFuncionario);

            return funcionario;
        }

        [HttpGet("Pesquisar Funcionario por Id")]
        public ActionResult<string> PesquisarPorId(int idFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            string resultado;
            resultado = funcionario.PesquisarPorId(idFuncionario);

            return resultado;
        }

        [HttpGet("Pesquisar Funcionario por Nome")]
        public ActionResult<string> PesquisarPorNome(string nome)
        {
            Funcionario funcionario = new Funcionario();
            string resultado;
            resultado = funcionario.PesquisarPorNome(nome);

            return resultado;
        }

        [HttpGet("Pesquisar Todos Funcionarios")]
        public ActionResult<string> PesquisarTodos()
        {
            Funcionario funcionario = new Funcionario();
            string resultado;
            resultado = funcionario.ListarTodos();

            return resultado;
        }
    }
}
