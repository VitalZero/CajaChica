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
        private Configuracion config;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnFacturasClick(object sender, EventArgs e)
        {
            FacturasWindow facturasWindow = new FacturasWindow();
            facturasWindow.ShowDialog();
        }

        private void OnMenuConfigClick(object sender, EventArgs e)
        {
            ConfigWindow configWindow = new ConfigWindow(config);
            configWindow.ShowDialog();
        }

        private void OnMenuDeptoClick(object sender, EventArgs e)
        {
            DeptoWindow deptoWindow = new DeptoWindow();
            deptoWindow.ShowDialog();
        }

        private void OnMenuAcercaDe(object sender, EventArgs e)
        {
            AboutBox aboutWindow = new AboutBox();
            aboutWindow.ShowDialog();
        }

        private void OnMenuCuentasClick(object sender, EventArgs e)
        {
            CuentaWindow cuentaWindow = new CuentaWindow();
            cuentaWindow.ShowDialog();
        }

        private void OnMainWindowLoad(object sender, EventArgs e)
        {
            config = new Configuracion();
            config.CargarDatos();
            fondoAsignado.Text = config.DarMonto().ToString("N2");

            //    // Crea archivos vacíos en la ruta configurada por defecto (Mis Documentos)
            //    if(!File.Exists(rutaPorDefecto + "\\cuentas.txt"))
            //    {
            //        File.OpenWrite(rutaPorDefecto + "\\cuentas.txt");
            //    }

            //    if (!File.Exists(rutaPorDefecto + "\\departamentos.txt"))
            //    {
            //        File.OpenWrite(rutaPorDefecto + "\\departamentos.txt");
            //    }
            //}
        }
    }
}
