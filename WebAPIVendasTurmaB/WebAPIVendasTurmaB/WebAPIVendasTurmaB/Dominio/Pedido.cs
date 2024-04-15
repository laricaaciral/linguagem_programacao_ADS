namespace WebAPIVendasTurmaB.Dominio
{
    public class Pedido
    {
        private int id;
        private DateTime dataPedido;
        private int funcionarioId;
        private int clienteId;
        private double valorTotal;

        public Pedido()
        {
        }

        public int Id { get => id; set => id = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public int FuncionarioId { get => funcionarioId; set => funcionarioId = value; }
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public void RegistrarVenda()
        {
        }

        public string ListarVenda()
        {
            return "";
        }
    }
}
