using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaCorrente : Conta
    {
        public double LimiteChequeEspecial { get; private set; }
        public ContaCorrente(string numero, string titular, decimal saldo, double limite)
            : base(numero, titular, saldo)
        {
            LimiteChequeEspecial = limite;
        }

        public void Sacar(decimal valor)
        {
            Console.WriteLine($"Tentativa de saque valor: {valor:C} na {this.GetType().Name} de {this.Titular}");
            if (valor <= Saldo + (decimal)LimiteChequeEspecial)
            {
                Saldo -= (decimal)valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque, incluindo o limite do cheque especial.");
            }
        }

    }
}
