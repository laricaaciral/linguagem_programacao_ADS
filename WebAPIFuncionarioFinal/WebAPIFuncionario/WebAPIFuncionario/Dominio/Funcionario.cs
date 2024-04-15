namespace WebAPIFuncionario.Dominio
{
    public class Funcionario
    {
        public string nome;
        public int idade;
        public string sexo;
        public double salario;

        public double calcularDecimoTerceiro(int mesesTrabalhados)
        {
            double decimoTerceiro;
            decimoTerceiro = salario * mesesTrabalhados / 12;
            return decimoTerceiro;
        }

        public void calcularFerias()
        {
            double ferias;
            ferias = salario * 1/ 3;
            salario = salario + ferias;
        }
    }
}
