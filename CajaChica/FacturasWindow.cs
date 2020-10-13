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
    public partial class FacturasWindow : Form
    {
        Cuentas cuentas;

        public FacturasWindow(Cuentas cuentas)
        {
            InitializeComponent();
            this.cuentas = cuentas;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if(cuentas.DarConteo() > 0)
            {
                cuentas.CargarDatos();
                List<string> cuentasLista = cuentas.DarCuentas();
                foreach(var s in cuentasLista)
                {
                    cuenta.AutoCompleteCustomSource.Add(s);
                }
            }
        }
    }
}
