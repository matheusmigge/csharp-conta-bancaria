using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaCorrente : Conta, ITributavel
    {
        public double LimiteChequeEspecial { get; private set; }

        public ContaCorrente(string numero, string titular, decimal saldo, double limite)
            : base(numero, titular, saldo)
        {
            LimiteChequeEspecial = limite;
        }

        public override void Sacar(decimal valor)
        {
            Console.WriteLine($"Tentativa de saque valor: {valor:C} na {this.GetType().Name} de {this.Titular}");
            if (valor <= Saldo + (decimal)LimiteChequeEspecial)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque, incluindo o limite do cheque especial.");
            }
        }

        public double CalcularImposto()
        {
            return (double)Saldo * 0.02;
        }
    }
}
