namespace WebAPIContaBancaria.Dominio
{
    public class ContaCorrente
    {
        public int numero;
        public string nome;
        private double saldo = 100;

        public ContaCorrente(int numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
        }

        public void Sacar(double valorSacado)
        {
            saldo -= valorSacado;
        }

        public void Depositar(double valorDepositado)
        {
            saldo += valorDepositado;
        }
    }
}
