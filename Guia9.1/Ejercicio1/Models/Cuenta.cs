using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cuenta:IComparable
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        DateTime Fecha { get; set; }
        public Persona Titular { get; set; }
        public Cuenta(int numero,Persona titular) 
        {
            this.Numero=numero;
            this.Titular=titular;
        }
        public Cuenta(int numero, Persona titular, DateTime fecha, double saldo) 
        {
            this.Saldo=saldo;
            this.Fecha=fecha;
            this.Numero=numero;
            this.Titular = titular;
        }

        public int CompareTo(object? obj)
        {
            Cuenta cuenta = obj as Cuenta;
            if (cuenta!=null)
            {
                return Numero.CompareTo(cuenta.Numero);
            }
            return -1;
        }
    }
}
