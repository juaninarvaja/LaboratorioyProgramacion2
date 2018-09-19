using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Ejercico31
{
    public enum  Puesto
    {
        Caja1,
        Caja2
    }


    public class PuestoAtencion
    {
        static private int numeroActual;
        private Puesto puesto;

   
        public static int NumeroActual
        {
           
            get{
                numeroActual++;
                    return numeroActual; }
        }
        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public bool Atender(Cliente cliente)
        {
            bool puestoLibre;
            Thread.Sleep(1500);
            puestoLibre = true;
            return puestoLibre;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
      

    }
}
