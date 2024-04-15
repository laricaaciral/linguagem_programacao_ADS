namespace WebAPIExercicio1Encapsulamento.Dominio
{
    public class Pessoa
    {
        private long id;
        private string nome;
        private int idade;

        public long Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public string VerificaIdadeCNH()
        {
            string resultado = "";
            if (idade >=18)
            {
                resultado = "Essa pessoa pode dirigir";
            }else
            {
                resultado = "Essa pessoa não pode dirigir";
            }
            return resultado;
        }



        //public long getId()
        //{
        //    return Id;
        //}
        //public void setId(long Id)
        //{
        //    this.Id = Id;
        //}
    }
}
