using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string numero, string titular, decimal saldo)
            : base(numero, titular, saldo)
        {

        }
    }
}
