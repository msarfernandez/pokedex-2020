using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace winform
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon nuevo = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Tipo = (Tipo)cboTipo.SelectedItem;

            negocio.agregar(nuevo);

            MessageBox.Show("Agregado Exitosamente", "Exito");
            Close();


        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            TipoNegocio tipoNegocio = new TipoNegocio();

            cboTipo.DataSource = tipoNegocio.listar();
        }
    }
}
