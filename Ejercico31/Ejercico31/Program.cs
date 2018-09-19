using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente unCliente = new Cliente("marcos", 1);
            Cliente unCliente2 = new Cliente("matias", 2);
            Negocio unNegocio = new Negocio("UTN");
            PuestoAtencion puestoUno = new PuestoAtencion(Puesto.Caja1);
            PuestoAtencion puestoDos = new PuestoAtencion(Puesto.Caja2);
            unNegocio.Cliente = unCliente;
            unNegocio.Cliente = unCliente2;
            Console.WriteLine(unNegocio.clientesPendientes);
            Console.ReadKey();

            while (unNegocio.clientesPendientes > 0)
            {
                if(~unNegocio)
                {
                    Console.WriteLine(unNegocio.clientesPendientes);
                    Console.ReadKey();
                }

            }

        }
    }
}
