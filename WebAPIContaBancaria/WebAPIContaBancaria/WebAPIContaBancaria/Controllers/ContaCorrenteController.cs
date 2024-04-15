using Microsoft.AspNetCore.Mvc;
using WebAPIContaBancaria.Dominio;

namespace WebAPIContaBancaria.Controllers
{
    public class ContaCorrenteController : ControllerBase
    {
        [HttpGet("Sacar")]
        public ActionResult<string> Sacar(double valor, int numeroConta, string nomeCliente)
        {
            ContaCorrente contaCorrente = new ContaCorrente();  
            contaCorrente.numero=numeroConta;
            contaCorrente.nome=nomeCliente;
            contaCorrente.Sacar(valor);

            string extrato = $"Após o saque de R${valor}, o cliente {contaCorrente.nome} titular da conta número {contaCorrente.numero} ficou com um saldo de R${contaCorrente.saldo}";

            return extrato;

        }

        [HttpGet("Depositar")]
        public ActionResult<string> Depositar(double valor, int numeroConta, string nomeCliente)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.numero = numeroConta;
            contaCorrente.nome = nomeCliente;
            contaCorrente.Depositar(valor);

            string extrato = $"Após o deposito de R${valor}, o cliente {contaCorrente.nome} titular da conta número {contaCorrente.numero} ficou com um saldo de R${contaCorrente.saldo}";

            return extrato;

        }
    }
}
