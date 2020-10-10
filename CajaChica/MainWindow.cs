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
    }
}
