using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Ejericio58
{
    public abstract class Archivo
    {
        public virtual bool ValidarArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new FileNotFoundException();              
            }
            else return true;
        }
    }
}
