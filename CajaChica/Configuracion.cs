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
        public Configuracion()
        {
            InitializeComponent();
        }

        private void OnSeleccionarClick(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                directorioArchivos.Text = folderBrowser.SelectedPath;
            }
        }
    }
}
