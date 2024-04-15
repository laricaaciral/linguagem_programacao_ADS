using Microsoft.AspNetCore.Mvc;
using WebAPIVendasTurmaB.Dominio;

namespace WebAPIVendasTurmaB.Controllers
{
    public class ItemVendaController : ControllerBase
    {
        [HttpPost("Inserir Item")]
        public ActionResult<ItemVenda> InserirItem(ItemVenda itemVendaTela)
        {
            ItemVenda itemVenda = new ItemVenda();
            itemVenda.ProdutoId = itemVendaTela.ProdutoId;
            itemVenda.VendaId = itemVendaTela.VendaId;
            itemVenda.QuantidadeProduto = itemVendaTela.QuantidadeProduto;
            itemVenda.PrecoUnitario = itemVendaTela.PrecoUnitario;

            itemVenda.InserirItem();

            return itemVenda;
        }

        [HttpDelete("Excluir Item")]
        public ActionResult<ItemVenda> ExcluirItem()
        {
            ItemVenda itemVenda = new ItemVenda();
          
            itemVenda.ExcluirItem();

            return itemVenda;
        }
    }
}
