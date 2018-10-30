using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Ejericio58
{
    class Puntotxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string obj)
        {
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        public override bool ValidarArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new FileNotFoundException();
            }
            else if (Path.GetExtension(ruta) != ".txt")
            {
                throw new ArchivoIncorrectoExcepciones;
            }
            else return true;
        }

    }
}
