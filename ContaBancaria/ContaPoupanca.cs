using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaPoupanca : Conta
    {
        public decimal TaxaJuros { get; set; }

        private const double TAXA_SAQUE = (double)2.78m;

        public ContaPoupanca(string numero, string titular, decimal saldo, decimal taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AdicionarJuros()
        {
            decimal juros = Saldo * TaxaJuros / 100;
            Saldo += juros;
            Console.WriteLine($"Juros de {TaxaJuros}% adicionados. Novo saldo: {Saldo:C}");

        }

        public override void Sacar(decimal valor)
        {
            Console.WriteLine($"Tentativa de saque valor: {valor:C} na {this.GetType().Name} de {this.Titular}");

            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque inválido. O valor deve ser maior que zero.");
                return;
            }

            if (valor + (decimal)TAXA_SAQUE <= Saldo)
            {
                Saldo -= (valor + (decimal)TAXA_SAQUE);
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque, incluindo a taxa de saque.");
            }

        }

    }

}
