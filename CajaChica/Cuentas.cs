using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaChica
{
    class Cuentas
    {
        private string archivo;
        private Dictionary<int, string> cuentas;

        public Cuentas(Configuracion config)
        {
            archivo = config.DarRuta() + "\\cuentas.txt";
            cuentas = new Dictionary<int, string>();
        }

        public void Agregar(int idCuenta, string descCuenta)
        {
            if(!cuentas.ContainsKey(idCuenta))
            {
                cuentas.Add(idCuenta, descCuenta);
            }
        }

        public void CargarDatos()
        {
            if(File.Exists(archivo))
            {
                cuentas.Clear();

                using(StreamReader file = new StreamReader(archivo))
                {
                    string temp;
                    char[] separator = { ' ' };
                    while((temp = file.ReadLine()) != null)
                    {
                        string[] pairs = temp.Split(separator, 2, StringSplitOptions.None);
                        Agregar(Int32.Parse(pairs[0]), pairs[1]);
                    }
                }
            }
            else
            {
                File.OpenWrite(archivo);
            }
        }

        public void GuardarDatos()
        {
            try
            {
                using (StreamWriter file = new StreamWriter(archivo))
                {
                    foreach (var c in cuentas)
                    {
                        file.WriteLine(c.Key + " " + c.Value);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo guardar el archivo de cuentas.\n"
                    + e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
