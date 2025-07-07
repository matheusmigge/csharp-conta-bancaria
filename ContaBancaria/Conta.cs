using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        protected double _saldo;
        public String Numero { get; set; }

        public String Titular { get; set; }

        public decimal Saldo { get; set; }

        public Conta(string numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta(string numero, string titular, decimal saldo)
        {

            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"{valor:C} depositado com sucesso.");
        }


        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"{valor:C} sacado com sucesso.");
            }

        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo:C}");
        }
    }

}
