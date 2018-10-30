using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Ejericio58
{
    public class ArchivoIncorrectoExcepciones : Exception
    {
        
        public ArchivoIncorrectoExcepciones() : base("¡Extension incorrecta!");
    }
}
