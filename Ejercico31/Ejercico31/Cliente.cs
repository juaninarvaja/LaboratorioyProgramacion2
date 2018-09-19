using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(string nombre, int numero) : this(numero)
        {
            Nombre = nombre;
        }

        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }
        public int Numero
        {
            get { return this.numero; }
            
        }
        public static bool operator ==(Cliente clienteUno, Cliente clienteDos)
        {
            bool retorno;
            if (clienteUno.Numero == clienteDos.Numero)
            {
                retorno = true;
                return retorno;
            }
            else
            {
                retorno = false;
                return retorno;
            }
        }

        public static bool operator !=(Cliente clienteUno, Cliente clienteDos)
        {
            return !(clienteUno == clienteDos);

        }





    }




}
