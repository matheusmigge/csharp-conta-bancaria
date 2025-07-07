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
    }

}
