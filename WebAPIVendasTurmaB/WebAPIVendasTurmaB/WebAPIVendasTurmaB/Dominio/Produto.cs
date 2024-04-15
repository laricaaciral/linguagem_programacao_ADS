namespace WebAPIVendasTurmaB.Dominio
{
    public class Produto
    {
        private int id;
        private string nome;
        private string descricao;
        private int quantidadeEstoque;
        private int unidadeMedida;
        private double precoUnitario;
        private string imgProduto;

        public Produto()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int QuantidadeEstoque { get => quantidadeEstoque; set => quantidadeEstoque = value; }
        public int UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }
        public string ImgProduto { get => imgProduto; set => imgProduto = value; }

        public void Adicionar()
        {
        }

        public void Excluir(int idProduto)
        {
        }

        public void Alterar(int idProduto)
        {
        }

        public string PesquisarProdutoPorId( int idProduto)
        {
            return "";
        }

        public string ListarTodosProdutos()
        {
            return "";
        }

    }
}
