using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Ahorro : Cuenta
    {
        const decimal TOPE = 10000;
        public Ahorro(decimal saldo,string numero): base (saldo, numero)
        {
            Tipo = "Corriente";
        }

        public override string Consignar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return $"Se consigno {valor} su nuevo saldo es {Saldo}";
            }
            return $"No puede consignar valores negativos {valor}";
        }

        public override string Retirar(decimal valor)
        {
            if ((Saldo-valor) > TOPE)
            {
                Saldo += valor;
                return $"Se Retiro {valor} su nuevo saldo es {Saldo}";
            }
            return $"Saldo Insuficiente su saldo actuel es de {Saldo} y el debe dejar un tope de {TOPE} no se puede retirar el valor {valor}";
        }
    }
}
