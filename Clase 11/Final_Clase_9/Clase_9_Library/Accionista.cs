using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_8_Library;


namespace Clase_9_Library
{
  public class Accionista : Persona
  {
    private int _porcionAccionaria;// entero, privado y de instancia
    string _legajo;
    
    

    public Accionista(string nombre, string apellido, string legajo,int porcionAccionaria)
            : base(nombre, apellido)
    {
      this._legajo = legajo;
     
      this._porcionAccionaria = porcionAccionaria;
    }


    public Accionista(Persona persona, int porcionAccionaria) : base(persona.Nombre, persona.Apellido)
    {
      _porcionAccionaria = porcionAccionaria;
    }
    public override string posicionSocietaria()
    {
      return "Accionista de la Empresa con el " + _porcionAccionaria + " de la empresa";
    }
    //                               //Propiedades:
    public int PorcionAccionaria
    {
      set
      {
        if (value > 0 && value < 100)
        {
          _porcionAccionaria = value;
        }
      }
    }

    public static bool operator ==(Accionista  a1, Accionista a2)
    {
     
      // Controlo que ninguno de los dos empleados no haya sido instanciado, para evitar errores.
      if (!object.ReferenceEquals(a1, null) && !object.ReferenceEquals(a2, null))
      {
        if (a1.Nombre == a2.Nombre && a1.Apellido == a2.Apellido)
          return true;
      }
      return false;
    }
    public static bool operator !=(Accionista a1, Accionista a2)
    {
      return !(a1 == a2);
    }


      //  //público y de instancia.Validará que la porción sea un número entre 0 y 100.
      //Métodos:
      //PosicionSocietaria deberá retornar el texto “Accionista con el[porción accionaria]% de la porción accionaria”.
      //Dos accionistas serán iguales si comparten todos sus datos.
    }
}
