using Microsoft.AspNetCore.Mvc;
using WebAPIVendasTurmaB.Dominio;

namespace WebAPIVendasTurmaB.Controllers
{
    public class PedidoController : ControllerBase
    {
        [HttpPost("Registar Venda")]
        public ActionResult<Pedido> RegistrarVenda(Pedido pedidoTela)
        {
            Pedido pedido = new Pedido();
            pedido.DataPedido = pedidoTela.DataPedido;
            pedido.FuncionarioId = pedidoTela.FuncionarioId;
            pedido.ClienteId = pedidoTela.ClienteId;
            pedido.ValorTotal = pedidoTela.ValorTotal;

            pedido.RegistrarVenda();

            return pedido;
        }

        [HttpGet("Listar Venda")]
        public ActionResult<string> ListarVenda(Pedido pedidoTela)
        {
            Pedido pedido = new Pedido();
            string resultado;

            resultado = pedido.ListarVenda();

            return resultado;
        }
    }
}
