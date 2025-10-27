using Ejercicio1.Models;
using System.Globalization;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Cuenta cuenta = banco.AgregarCuenta((int)1001, (int)28456789, "Ana Lopéz");
            cuenta.Saldo = 111.1;
            Cuenta cuenta1 = banco.AgregarCuenta((int)1002, (int)30123456, "Carlos Méndez");
            cuenta1.Saldo = 3123.3;
            Cuenta cuenta2 = banco.AgregarCuenta((int)1005, (int)30123456, "Carlos Méndez");
            cuenta2.Saldo = 4123.4;
            Cuenta cuenta3 = banco.AgregarCuenta((int)1003, (int)25987654, "Lucía Fernández");
            cuenta3.Saldo = 12344.4;
            Cuenta cuenta4 = banco.AgregarCuenta((int)1004, (int)32876543, "Martín Ruiz");
            cuenta4.Saldo = 12;
            Cuenta cuenta5 = banco.AgregarCuenta((int)1006, (int)27654321, "Sofía Gómez");
            cuenta5.Saldo = 123333.3;


        }

        private void btnVerCuentas_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Número de cuenta | Nombre | Saldo ");
            foreach (Cuenta c in banco.listacuentas)
            {
                listBox1.Items.Add(c);
                listBox1.Items.Add("-------------------------------------");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    CultureInfo cultura = CultureInfo.CurrentCulture;
                    string linea = sr.ReadLine().Trim(); ;
                    string[] cadena = linea.Split(';');

                    int dni = Convert.ToInt32(cadena[0],cultura);
                    string nombre = cadena[1];
                    int numeroDeCuenta = Convert.ToInt32(cadena[2],cultura);
                    Double saldo = Convert.ToDouble(cadena[3]);

                    Cuenta cuenta = banco.VerCuentaPorNumero(numeroDeCuenta);
                    if (cuenta == null)
                    {
                        cuenta=banco.AgregarCuenta(numeroDeCuenta, dni, nombre);
                        cuenta.Saldo = saldo;
                    }
                    else
                    {
                        cuenta.Saldo += saldo;
                    }
                    
                }
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*List<Cuenta> CuentasMasMil = new List<Cuenta>();

                foreach (Cuenta c in banco.listacuentas)
                {
                    if (c.Saldo>1000)
                    {
                        CuentasMasMil.Add(c); otra opcion, se puede achicar el codigo 
                    }
                }*/
                string path =saveFileDialog1.FileName;
                FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("DNI; nombre; número de cuenta; saldo");
                foreach (Cuenta c in banco.listacuentas)
                {
                    if (c.Saldo > 1000)
                    { sw.WriteLine($"{c.Titular.DNI};{c.Titular.Nombre};{c.Numero};{c.Saldo}"); }
                }



            }





        }

       
    }
}
