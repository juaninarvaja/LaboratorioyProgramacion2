using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
  public abstract class Persona
  {
    protected string _nombre;
    protected string _apellido;
    abstract public string posicionSocietaria();

   virtual protected string Mostrar(Persona p)
    {
      return "Nombre :" + _nombre +" Apellido: " + _apellido + "  " +posicionSocietaria();
    }

  public Persona(string nombre, string apellido)
  {
    this._nombre = nombre;
    this._apellido = apellido;
  }
  
  public string Nombre
  {
    get
    {
      return this._nombre;
    }
  }
  public string Apellido
  {
    get
    {
      return this._apellido;
    }
  }
}
}
