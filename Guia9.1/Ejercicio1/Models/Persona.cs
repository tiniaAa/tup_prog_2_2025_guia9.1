using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Persona:IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona(int dni, string nombre) 
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }

        public int CompareTo(object? obj)
        {
            Persona persona = obj as Persona;
            if (persona!=null)
            {
                return DNI.CompareTo(persona.DNI);
            }
            return -1;
        }
        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
