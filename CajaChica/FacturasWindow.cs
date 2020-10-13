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
        private Cuentas cuentas;
        private Departamentos deptos;

        public FacturasWindow(Cuentas cuentas, Departamentos deptos)
        {
            InitializeComponent();
            this.cuentas = cuentas;
            this.deptos = deptos;
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

            if (deptos.DarConteo() > 0)
            {
                deptos.CargarDatos();
                List<string> deptosLista = deptos.DarDeptos();
                foreach (var s in deptosLista)
                {
                    departamentos.AutoCompleteCustomSource.Add(s);
                }
            }
        }
    }
}
