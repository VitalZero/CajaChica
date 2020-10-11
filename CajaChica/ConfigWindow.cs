using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaChica
{
    public partial class ConfigWindow : Form
    {
        Configuracion config;

        public ConfigWindow(Configuracion config)
        {
            InitializeComponent();
            this.config = config;
        }

        private void OnSeleccionarClick(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                directorioArchivos.Text = folderBrowser.SelectedPath;
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            directorioArchivos.Text = config.DarRuta();
            fondo.Text = config.DarMonto().ToString("N2");
            custodio.Text = config.DarCustodio();
        }

        private void OnAceptarClick(object sender, EventArgs e)
        {
            config.FijarCustodio(custodio.Text);
            config.FijarMonto(Convert.ToDouble(fondo.Text));
            config.FijarRuta(directorioArchivos.Text);
            config.GuardarDatos();
        }
    }
}
