namespace WebAPIVendasTurmaB.Dominio
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string cpfCnpj;
        private string email;
        private double telefone;
        private string endereco;

        public Cliente()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CpfCnpj { get => cpfCnpj; set => cpfCnpj = value; }
        public string Email { get => email; set => email = value; }
        public double Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public void Adicionar()
        {
        }

        public void Excluir(int IdCliente)
        {
        }

        public void Alterar(int IdCliente)
        {
        }

        public string PesquisarPorId(int IdCliente)
        {
            return "";
        }

        public string ListarTodos()
        {
            return "";
        }

        public string PesquisarPorNome(string NomeCliente)
        {
            return "";
        }
    }
}
