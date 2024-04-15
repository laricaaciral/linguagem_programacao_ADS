using Microsoft.AspNetCore.Mvc;
using WebAPIVendasTurmaB.Dominio;

namespace WebAPIVendasTurmaB.Controllers
{
    public class ProdutoController : ControllerBase
    {
        [HttpPost("Adicionar Produto")]
        public ActionResult<Produto> Adicionar(Produto produtoTela)
        {
            Produto produto = new Produto();
            produto.Nome = produtoTela.Nome;
            produto.Descricao = produtoTela.Descricao;
            produto.QuantidadeEstoque = produtoTela.QuantidadeEstoque;
            produto.UnidadeMedida = produtoTela.UnidadeMedida;
            produto.PrecoUnitario = produtoTela.PrecoUnitario;
            produto.ImgProduto = produtoTela.ImgProduto;

            produto.Adicionar();

            return produto;
        }

        [HttpDelete("Excluir Produto")]
        public ActionResult<Produto> Excluirr(int idProduto)
        {
            Produto produto = new Produto();
            
            produto.Excluir(idProduto);

            return produto;
        }

        [HttpPut("Alterar Produto")]
        public ActionResult<Produto> Alterar(Produto produtoTela)
        {
            Produto produto = new Produto();
            produto.Nome = produtoTela.Nome;
            produto.Descricao = produtoTela.Descricao;
            produto.QuantidadeEstoque = produtoTela.QuantidadeEstoque;
            produto.UnidadeMedida = produtoTela.UnidadeMedida;
            produto.PrecoUnitario = produtoTela.PrecoUnitario;
            produto.ImgProduto = produtoTela.ImgProduto;

            produto.Alterar(produtoTela.Id);

            return produto;
        }

        [HttpGet("Pesquisar Produto por Id")]
        public ActionResult<string> PesquisarProdutoPorId(int idProduto)
        {
            Produto produto = new Produto();
            string resultado;
            resultado = produto.PesquisarProdutoPorId(idProduto);

            return resultado;
        }

        [HttpGet("Listar Todos Produtos")]
        public ActionResult<string> ListarTodosProdutos()
        {
            Produto produto = new Produto();
            string resultado;
            resultado = produto.ListarTodosProdutos();

            return resultado;
        }
    }
}
