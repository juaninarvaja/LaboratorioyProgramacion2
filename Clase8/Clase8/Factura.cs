using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    public class Factura
    {
        private int numero;
        private DateTime fecha;
        private int moneda;
         List<Producto> productos;
       private double total;//borrar este y hacer un a prop publica
        int tipo;

        public Producto this[int i]
        {
            get
            {
                Producto salida = null;
                    foreach(Producto item in this.productos)
                    {
                    if (item.Identificador == i)
                    { salida = item; }
                    }

                if (salida == null)
                {
                    return null;
                }
                else return null;
            }
            set
            {

                    bool encontro = false;
                    foreach (Producto item in this.productos)
                    {
                        if (item.Identificador == i)
                        {
                            item.Cantidad += value.Cantidad;
                            encontro = true;
                        }
                    }
                    if (!encontro)
                    {
                        this.productos.Add(value);
                    }
                }


            }

        }

        public Factura()
        {
            this.productos = new List<Producto>();
        }


        public Factura(int numero)
        {
            this.numero = numero;

        }

        public double Total
        {
            get {
                foreach (Producto item in this.productos)
                {
                    total += item.Total;
                }
                return total;
            }
        }
        


    }
}
