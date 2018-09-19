using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        public int clientesPendientes;
      

        public Cliente Cliente
        {
            get { clientesPendientes--;
                return clientes.Dequeue(); }
            set
            {
                //if (!clientes.Contains(value))
                if (this != value)
                {
                    clientes.Enqueue(value);
                    clientesPendientes = clientes.Count;
                }
            }
        }


        private Negocio()
        {
            caja = new PuestoAtencion(Puesto.Caja1);
            clientes = new Queue<Cliente>();
           
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            bool yaExiste = false;
            foreach (Cliente cli in negocio.clientes)
            {
                if (cli == cliente)
                {
                    yaExiste = true;
                    break;
                }
            }
            return yaExiste;
        }
        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);

        }

        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            bool sumo;
            if (negocio != cliente)
            {
                sumo = true;
                negocio.Cliente = cliente;
            }
            else sumo = false;

            return sumo;
        }

        public static bool operator ~(Negocio negocio)
        {
             return negocio.caja.Atender(negocio.Cliente);

        }

    }
}
