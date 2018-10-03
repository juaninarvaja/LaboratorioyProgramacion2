using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public string anioDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.anio.ToString() + "º");
                sb.Append(this.division.ToString());

                return sb.ToString();
            }

        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("profesor : " + c.profesor.ExponerDatos());
            foreach (Persona p in c.alumnos)
            {
                
                sb.AppendFormat("Alumno :" + p.ExponerDatos());
            }
            return sb.ToString();
        }
        public static Curso operator +(Curso c, Alumno alumno)
        {

            // Si encuentro al empleado en la nómina, salgo del método.
            if (c == alumno)
            {
               c.alumnos.Add(alumno);
                return c;
            }
            return c;
            // Agrego al empleado a la nómina
        }

        public static bool operator ==(Curso c, Alumno alumno)
        {
            // Si encuentro al empleado en la nómina, salgo del método.
            if (c.anioDivision == alumno.anioDivision)
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Curso c, Alumno alumno)
        {
            return !(c == alumno);

        }

    }
}

