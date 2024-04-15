using Microsoft.AspNetCore.Mvc;
using WebAPIExercicio1Encapsulamento.Dominio;

namespace WebAPIExercicio1Encapsulamento.Controllers
{
    public class PessoaController : ControllerBase
    {
        [HttpPost("Pessoa")]
        public ActionResult<Pessoa> Pessoa(long idPessoa, string nomePessoa, int idadePessoa)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id=idPessoa;
            pessoa.Nome=nomePessoa;
            pessoa.Idade=idadePessoa;

            return pessoa;
        }
    }
}
