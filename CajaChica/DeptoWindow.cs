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
    public partial class DeptoWindow : Form
    {
        private Departamentos departamentos;

        public DeptoWindow(Departamentos departamentos)
        {
            InitializeComponent();
            this.departamentos = departamentos;
        }

        private void OnAceptarClick(object sender, EventArgs e)
        {
            departamentos.Agregar(Convert.ToInt32(idDepartamento.Text), descripcion.Text);

            idDepartamento.Text = "";
            descripcion.Text = "";

            departamentos.GuardarDatos();

            this.Close();
        }
    }
}
