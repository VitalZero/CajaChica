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
    public partial class CuentaWindow : Form
    {
        Cuentas cuentas;

        public CuentaWindow(Cuentas cuentas)
        {
            InitializeComponent();
            this.cuentas = cuentas;
        }

        private void OnAceptarClick(object sender, EventArgs e)
        {
            cuentas.Agregar(Convert.ToInt32(idCuenta.Text), descripcion.Text);

            idCuenta.Text = "";
            descripcion.Text = "";

            cuentas.GuardarDatos();

            this.Close();
        }
    }
}
