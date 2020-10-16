using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaChica
{
    public class Cuentas
    {
        private string archivo;
        private Dictionary<int, string> cuentas;

        public Cuentas(Configuracion config)
        {
            archivo = config.DarRuta() + "\\cuentas.txt";
            cuentas = new Dictionary<int, string>();
        }

        public int DarConteo()
        {
            return cuentas.Count;
        }

        public List<string> DarCuentas()
        {
            //if(DarConteo() == 0)
            //{
            //    return null;
            //}

            List<string> temp = new List<string>();

            foreach(var c in cuentas)
            {
                temp.Add(c.Key.ToString() + " " + c.Value);
            }

            return temp;
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

                    file.Close();
                }
            }
            else
            {
                FileStream fs = File.OpenWrite(archivo);
                fs.Close();
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

                    file.Close();
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
