using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    public class Producto
    {
        private int id;
        private string nombre;
        private double precio; //solo escritura 
        private double iva; // no tiene prop
        //TOtal ---> solo lectura, devuelve precio mas iva
        private int Cantidad;

        public Producto(int id)
        {
            this.id = id;
        }

        public Producto(int id,string nombre,double precio) : this(id)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.iva = CalcularIva(precio);
        }

        private double CalcularIva(double precio)
        {
            return precio * 1.21;
        }
        //public double getTotal()
        //{
        //    this.iva = this.precio * .21;
        //    return this.precio * 1.21;
        //}
        public int Identificador {
            get{ return this.id; }
            set {this.id = value;}
        }
        public double Precio
        {
            set { this.precio = value;}
        }
        public string Nombre
        {
            get { return this.nombre;}
            set { this.nombre = value;}
        }
        public double Total
        {
            get { return this.precio *1.21; }
        }

    }
}
