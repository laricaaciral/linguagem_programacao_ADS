namespace WebAPIVendasTurmaB.Dominio
{
    public class ItemVenda
    {
        private int produtoId;
        private int vendaId;
        private int quantidadeProduto;
        private double precoUnitario;

        public ItemVenda()
        {
        }

        public int ProdutoId { get => produtoId; set => produtoId = value; }
        public int VendaId { get => vendaId; set => vendaId = value; }
        public int QuantidadeProduto { get => quantidadeProduto; set => quantidadeProduto = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }

        public void InserirItem()
        {
        }

        public void ExcluirItem()
        {
        }
    }
}
