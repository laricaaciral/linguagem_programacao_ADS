namespace WebAPIVendasTurmaB.Dominio
{
    public class Funcionario
    {
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private string cargo;
        private double salario;
        private DateTime dataAdmissao;

        public Funcionario()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }


        public void Adicionar()
        {
        }

        public void Excluir(int idFuncionario)
        {
        }

        public void Alterar(int idFuncionario)
        {
        }

        public string PesquisarPorId( int idFuncionario)
        {
            return "";
        }

        public string ListarTodos()
        {
            return "";
        }

        public string PesquisarPorNome(string nomeFuncionario)
        {
            return "";
        }

        internal void Alterar()
        {
            throw new NotImplementedException();
        }
    }
}
