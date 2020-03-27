using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    abstract  class Cuenta:IServicioFinanciero
    {

        public decimal Saldo { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }

        public Cuenta(decimal saldo,string numero)
        {
            Saldo = saldo;
            Numero = numero;
        }

        public abstract string Consignar(decimal valor);
       

         public void ConsultarSaldo()
        {

        }

        public abstract string Retirar(decimal valor);
    }
}
