using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {
                DateTime oldDate = this.fechaIngreso;
                DateTime newDate = DateTime.Now;
                TimeSpan ts = newDate - oldDate;
                int differenceInDays = ts.Days;
                return differenceInDays; 

            }

        }


        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        {
        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ExponerDatos());

            sb.AppendFormat("fecha de ingreso" + fechaIngreso.ToString());
            sb.AppendFormat(" \n antiguedad: " + this.Antiguedad.ToString() + "Dias \n");
            

            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string documento)
        {
            return true; //hacer bien aca y en alumno
        }
    }
}
