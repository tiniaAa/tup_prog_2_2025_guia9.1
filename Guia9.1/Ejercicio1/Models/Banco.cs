using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public  class Banco
    {
        List<Cuenta> Cuentas = new List<Cuenta>();
        List<Persona> Clientes = new List<Persona>();

        public List<Cuenta> listacuentas { get { return Cuentas; } }
        public List<Persona> listPersonas { get { return Clientes; } }
        public int CantidadCuntas 
        {
            get 
            {
                return Cuentas.Count;
            }
            set { }
        }
        public int CantidadClientes 
        {
            get 
            {
                return Clientes.Count;
            }
            set { }
        }

        public Cuenta this[int idx]
        {
            get 
            {
                if (idx >=0 &&idx <Cuentas.Count)
                {
                    return Cuentas[idx];
                }
                return null;
            }
            set { }
        }
        public Cuenta AgregarCuenta(int numeroCuenta, int dni, string Nombre)
        {
            if (VerCuentaPorNumero(numeroCuenta) != null) return null;

            Persona titular = VerClientePorDNI(dni);
            if (titular==null)
            {
                titular = new Persona(dni, Nombre);
                Clientes.Add(titular);
            }
            Cuenta cuenta = new Cuenta(numeroCuenta,titular);
            Cuentas.Add(cuenta);
            return cuenta;
        }
        public Cuenta VerCuentaPorNumero(int numeroCuenta)
        {
            Cuenta cuentaBus = new Cuenta(numeroCuenta,null);
            Cuentas.Sort();
            int idx = Cuentas.BinarySearch(cuentaBus);

            if (idx>=0)
            {
                Cuenta cuenta = Cuentas[idx];

                return cuenta;
            }
            return null;
        }
        public Persona VerClientePorDNI(int DNI)
        {
            Persona cuentaBus = new Persona(DNI,null);
            Clientes.Sort();
            int idx = Clientes.BinarySearch(cuentaBus);
            if (idx >= 0)
            {
                Persona cliente = Clientes[idx];

                return cliente; 
            }
            return null;
        }
        public bool RestaurarCuenta(int numero, double saldo, DateTime fecha, Persona persona)
        {


            if (VerCuentaPorNumero(numero)==null)
            {
                Persona cliente = VerClientePorDNI(persona.DNI);
                if (cliente==null)
                {
                    cliente = persona;
                    Clientes.Add(cliente);

                }
                Cuenta cuentaRes = new Cuenta(numero,cliente,fecha,saldo);
                Cuentas.Add(cuentaRes);
                return true;
            }
            return false;
        }

    }
}
