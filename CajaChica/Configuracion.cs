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
    public partial class Configuracion : Form
    {
        Settings settings;

        public Configuracion()
        {
            InitializeComponent();
        }
        public void FijarSettings(Settings settings)
        {
            this.settings = settings;
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
            directorioArchivos.Text = settings.DarRuta();
            fondo.Text = settings.DarMonto().ToString("N2");
            custodio.Text = settings.DarCustodio();
        }

        private void OnAceptarClick(object sender, EventArgs e)
        {
            settings.FijarCustodio(custodio.Text);
            settings.FijarMonto(Convert.ToDouble(fondo.Text));
            settings.FijarRuta(directorioArchivos.Text);
            settings.GuardarDatos();
        }
    }
}
