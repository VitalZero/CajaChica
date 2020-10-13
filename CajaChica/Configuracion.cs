using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaChica
{
    public class Configuracion
    {
        private double monto = 0.00;
        private string archivo;
        private string custodio;
        private string ruta;

        public Configuracion(string archivo = "config.cfg")
        {
            this.archivo = archivo;
            custodio = "SIN ASIGNAR";
            monto = 0.00;
        }

        public double DarMonto() { return monto; }

        public string DarCustodio() { return custodio; }

        public string DarRuta() { return ruta; }

        public void FijarMonto(double monto) { this.monto = monto; }

        public void FijarCustodio(string custodio) { this.custodio = custodio; }

        public void FijarRuta(string ruta) { this.ruta = ruta; }

        public void CargarDatos()
        {
            if (File.Exists(archivo))
            {
                using (StreamReader file = new StreamReader(archivo))
                {
                    string temp;
                    while ((temp = file.ReadLine()) != null)
                    {
                        if (temp == "[CUSTODIO]")
                        {
                            custodio = file.ReadLine();
                        }
                        else if (temp == "[MONTO]")
                        {
                            monto = Convert.ToDouble(file.ReadLine());
                        }
                        else if (temp == "[RUTA]")
                        {
                            ruta = file.ReadLine();
                        }
                        else if (temp.Trim().Length == 0)
                        {
                        }
                        else
                        {
                            throw new InvalidOperationException("Configuración no reconocida");
                        }
                    }
                    file.Close();
                }
            }
            else
            {
                ruta = Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);
                
                GuardarDatos();
            }
        }

        public void GuardarDatos()
        {
            try
            {
                using (StreamWriter file = new StreamWriter(archivo))
                {
                    file.WriteLine("[CUSTODIO]");
                    file.WriteLine(custodio);
                    file.WriteLine("[MONTO]");
                    file.WriteLine(monto);
                    file.WriteLine("[RUTA]");
                    file.WriteLine(ruta);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo guardar el archivo de configuración.\n"
                    + e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

