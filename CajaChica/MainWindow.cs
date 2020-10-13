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
        private Cuentas cuentas;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnFacturasClick(object sender, EventArgs e)
        {
            FacturasWindow facturasWindow = new FacturasWindow(cuentas);
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
            CuentaWindow cuentaWindow = new CuentaWindow(cuentas);
            cuentaWindow.ShowDialog();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            config = new Configuracion();
            config.CargarDatos();
            fondoAsignado.Text = config.DarMonto().ToString("N2");

            cuentas = new Cuentas(config);
            cuentas.CargarDatos();

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
