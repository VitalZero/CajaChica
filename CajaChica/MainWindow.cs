using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaChica
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnFacturasClick(object sender, EventArgs e)
        {
            FacturasWindow facturas = new FacturasWindow();
            facturas.ShowDialog();
        }

        private void OnMenuConfigClick(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.ShowDialog();
        }

        private void OnMenuDeptoClick(object sender, EventArgs e)
        {
            Departamentos departamentos = new Departamentos();
            departamentos.ShowDialog();
        }

        private void OnMenuAcercaDe(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void OnMenuCuentasClick(object sender, EventArgs e)
        {
            Cuentas cuentas = new Cuentas();
            cuentas.ShowDialog();
        }

        private void OnMainWindowLoad(object sender, EventArgs e)
        {
            if (File.Exists("config.cfg"))
            {

            }
            else
            {
                string rutaPorDefecto = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter file = new StreamWriter("config.cfg"))
                {
                    file.WriteLine("[CUSTODIO]");
                    file.WriteLine("SIN ASIGNAR");
                    file.WriteLine("[MONTO]");
                    file.WriteLine("0.00");
                    file.WriteLine("[RUTA]");
                    file.WriteLine(rutaPorDefecto);
                    file.Close();
                }

                // Crea archivos vacíos en la ruta configurada por defecto (Mis Documentos)
                if(!File.Exists(rutaPorDefecto + "\\cuentas.txt"))
                {
                    File.OpenWrite(rutaPorDefecto + "\\cuentas.txt");
                }

                if (!File.Exists(rutaPorDefecto + "\\departamentos.txt"))
                {
                    File.OpenWrite(rutaPorDefecto + "\\departamentos.txt");
                }
            }
        }
    }
}
