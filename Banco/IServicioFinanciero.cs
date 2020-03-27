using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    interface IServicioFinanciero
    {
        string Consignar(decimal valor);
        string Retirar(decimal valor);
    }
}
