using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public Alumno( string nombre, string apellido, string documento, short anio, Divisiones division) : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }
        protected override bool ValidarDocumentacion(string documento)
        {
            return true;
        }


        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ExponerDatos());
            sb.AppendFormat(this.anioDivision);
           

            return sb.ToString();
        }
        public string anioDivision
        {
            get{
                StringBuilder sb = new StringBuilder();
                sb.Append(this.anio.ToString()  + "º");
                sb.Append(this.division.ToString());

                return sb.ToString(); }

        }



    }
}
