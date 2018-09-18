using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Encapsulamiento: ocultamiento del estado, osea mostramos parte y mostramos lo q se necesite
 * solo se puede cambiar mediante las operacion
 * no se puede acceder a ellos a menos q tengas un metodo para esto
 * 3 niveles:
 * publico : todos pueden acceder
 * Protegido : son accesibles dentro de su clase y subclases
 * privado: solo puede acceder dentro de la clase
 * 
 * Propiedad ---> forma de encapsular
 * Propiedades: son atribuutos apra el afuera y para adentro como metodos
 * propiedades con mayuscula;
 * value devuelve lo q esta del otro lado del igual
 * 
*/ 
namespace Clase8
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
