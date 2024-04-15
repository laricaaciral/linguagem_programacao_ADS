using Microsoft.AspNetCore.Mvc;
using WebAPIFuncionario.Dominio;

namespace WebAPIFuncionario.Controllers
{
    public class FuncionarioController : ControllerBase
    {
        [HttpGet("Décimo Terceiro")]
        public ActionResult<string> DecimoTerceiro(string nomeFuncionario, int idadeFuncionario, string sexoFuncionario, double salarioFuncionario, int meses)
        {
            double valorDecimoTerceiro;

            Funcionario funcionario = new Funcionario();
            funcionario.nome = nomeFuncionario;
            funcionario.idade = idadeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.salario = salarioFuncionario;

            //valorDEcimoterceiro recebe o valor calculado pela função abaixo
            valorDecimoTerceiro = funcionario.calcularDecimoTerceiro(meses);

            string resultado = $"O funcionario {funcionario.nome} que tem {funcionario.idade} anos e recebe o salário R${funcionario.salario} terá direito a R${valorDecimoTerceiro} de décimo terceiro. ";
            return resultado;
        }

        [HttpGet("Ferias")]
        public ActionResult<string> Ferias(string nomeFuncionario, int idadeFuncionario, string sexoFuncionario, double salarioFuncionario)
        {

            Funcionario funcionario = new Funcionario();
            funcionario.nome = nomeFuncionario;
            funcionario.idade = idadeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.salario = salarioFuncionario;

            //Para calcular as ferias nao precisa criar nenhuma variavel, o metodo nao retorna
            funcionario.calcularFerias();

            string resultado = $"O funcionario {funcionario.nome} que tem {funcionario.idade} anos e receberá a título de férias um salário de R${funcionario.salario}.";
            return resultado;
        }
    }
}

