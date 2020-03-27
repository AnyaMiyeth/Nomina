using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Corriente : Cuenta
    {
        public decimal Cupo { get; set; }
        public Corriente(decimal saldo, string numero, decimal cupo): base(saldo, numero)
        {
            Cupo = cupo;
            Tipo = "Corriente";
            Numero = numero;
        }
        public void CrearCuenta(decimal cupo)
        {
            Cupo = cupo;
        }
        public override string Consignar(decimal valor)
        {
            if (ValidarSaldo(Saldo,valor))
            {
                Cupo += valor;
                Saldo -= valor;
                return $"Se consigno {valor} su nuevo saldo es {Saldo}";
            }
           
            return $"No es posible realzar su consignacion su saldo es de {Saldo} y su cupo actual es de {Cupo}";
        }

        public override string Retirar(decimal valor)
        {
            if (ValidarSaldo(Cupo,valor))
            {
                Cupo -= valor;
                Saldo += valor;
                return $"Se Retiro {valor} su nuevo saldo es {Saldo}";
            }
            return $"Saldo insuficiente su cupo actual es de  {Cupo} y tiene un saldo pendiente de {Saldo}";
        }

        public bool ValidarSaldo(decimal valorSaldo, decimal valorDescuento)
        {
            decimal total = valorSaldo - valorDescuento;
            return (total >= 0 ? true : false);
        }



        
    }
}
