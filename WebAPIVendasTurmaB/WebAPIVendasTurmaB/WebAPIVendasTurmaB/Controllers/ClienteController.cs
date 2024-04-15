using Microsoft.AspNetCore.Mvc;
using WebAPIVendasTurmaB.Dominio;

namespace WebAPIVendasTurmaB.Controllers
{
    public class ClienteController : ControllerBase
    {
        [HttpPost("Adicionar Cliente")]
        public ActionResult<Cliente> Adicionar(Cliente clienteTela)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = clienteTela.Nome;
            cliente.CpfCnpj = clienteTela.CpfCnpj;
            cliente.Email = clienteTela.Email;
            cliente.Telefone = clienteTela.Telefone;
            cliente.Endereco = clienteTela.Endereco;

            cliente.Adicionar();

            return cliente;
        }

        [HttpPut("Alterar Cliente")]
        public ActionResult<Cliente> Alterar(Cliente clienteTela)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = clienteTela.Nome;
            cliente.CpfCnpj = clienteTela.CpfCnpj;
            cliente.Email = clienteTela.Email;
            cliente.Telefone = clienteTela.Telefone;
            cliente.Endereco = clienteTela.Endereco;

            cliente.Alterar(clienteTela.Id);

            return cliente;
        }

        [HttpDelete("Excluir Cliente")]
        public ActionResult<Cliente> Excluir(int IdCliente) 
        {
            Cliente cliente = new Cliente();

            cliente.Excluir(IdCliente);

            return cliente;
        }

        [HttpGet("Pesquisar Cliente por Id")]
        public ActionResult<string> PesquisarPorId(int IdCliente)
        {
            Cliente cliente = new Cliente();
            string resultado;
            resultado = cliente.PesquisarPorId(IdCliente);

            return resultado;
        }

        [HttpGet("Pesquisar Cliente por Nome")]
        public ActionResult<string> PesquisarPorNome(string nome)
        {
            Cliente cliente = new Cliente();
            string resultado;
            resultado = cliente.PesquisarPorNome(nome);

            return resultado;
        }

        [HttpGet("Pesquisar Todos Cliente")]
        public ActionResult<string> PesquisarTodos()
        {
            Cliente cliente = new Cliente();
            string resultado;
            resultado = cliente.ListarTodos();

            return resultado;
        }
    }
}
