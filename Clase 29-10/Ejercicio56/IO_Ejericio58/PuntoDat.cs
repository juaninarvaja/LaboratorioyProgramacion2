using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Ejericio58
{
    class PuntoDat : Archivo , IArchivos<PuntoDat>
    {
        private string contenido;
         public string Contenido
        {
            get { return this.contenido; }
            set { this.contenido = value; }

        }



        public bool Guardar(string ruta, PuntoDat obj)
        {
            throw new NotImplementedException();
        }

        public PuntoDat Leer(string ruta)
        {
            throw new NotImplementedException();
            
        }

        public override bool ValidarArchivo(string ruta)
        {
            if (!File.Exists(ruta) && Path.GetExtension(ruta) != ".dat")
            {
                throw new FileNotFoundException();
            }
            else return true;
        }

    }
}
