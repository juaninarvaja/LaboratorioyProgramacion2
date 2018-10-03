using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  

    public abstract class Persona
    {
        protected string nombre;
        private string apellido;
        private string documento;

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Documento
        {
            get { return this.documento; }
            set { this.documento = value; }
        }
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" \n Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Dni: " + this.documento );
            
            return sb.ToString(); ;
        }
        protected abstract bool ValidarDocumentacion(string documento);
        //{
        //    //bool esValido = false;
        //    //if (documento[2] == '-' && documento[7] == '-')
        //    //{
        //    //    esValido = true;

        //    //}
        //    //return esValido;

        //}
    }
}
