using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaChica
{
    public class Departamentos
    {
        private string archivo;
        private Dictionary<int, string> departamentos;

        public Departamentos(Configuracion config)
        {
            archivo = config.DarRuta() + "\\departamentos.txt";
            departamentos = new Dictionary<int, string>();
        }

        public int DarConteo()
        {
            return departamentos.Count;
        }

        public List<string> DarDeptos()
        {
            if(DarConteo() == 0)
            {
                return null;
            }

            List<string> temp = new List<string>();

            foreach(var d in departamentos)
            {
                // + " " + d.Key.ToString()
                temp.Add(d.Value);
            }

            return temp;
        }

        public void Agregar(int idDepto, string descDepto)
        {
            if(!departamentos.ContainsKey(idDepto))
            {
                departamentos.Add(idDepto, descDepto);
            }
        }

        public void CargarDatos()
        {
            if (File.Exists(archivo))
            {
                departamentos.Clear();

                using (StreamReader file = new StreamReader(archivo))
                {
                    string temp;
                    char[] separator = { ' ' };
                    while ((temp = file.ReadLine()) != null)
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
                    foreach (var d in departamentos)
                    {
                        file.WriteLine(d.Key + " " + d.Value);
                    }

                    file.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo guardar el archivo de cuentas.\n"
                    + e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
