using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cuenta> cuentas = new List<Cuenta>();
            Cuenta cuentaAhorro = new Ahorro(100000,"1");
            string mensaje2 = cuentaAhorro.Consignar(100000);
            Console.WriteLine(mensaje2);
            string mensajeCorrriente;
            cuentas.Add(cuentaAhorro);

            Cuenta cuentaCorriente = new Corriente(0,"2", 100000);
            cuentas.Add(cuentaCorriente);
            mensajeCorrriente = cuentaCorriente.Retirar(50000);
            Console.WriteLine(mensajeCorrriente);
            
            mensajeCorrriente = cuentaCorriente.Retirar(50000);
            Console.WriteLine(mensajeCorrriente);

            mensajeCorrriente = cuentaCorriente.Retirar(100000);
            Console.WriteLine(mensajeCorrriente);

            mensajeCorrriente = cuentaCorriente.Consignar(100000);
            Console.WriteLine(mensajeCorrriente);

            mensajeCorrriente = cuentaCorriente.Consignar(50000);
            Console.WriteLine(mensajeCorrriente);

            foreach (var item in cuentas)
            {
                Console.WriteLine($"{item.Numero} y saldo {item.Saldo}");
            }

            Console.ReadKey();
        }
    }
}
