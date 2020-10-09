using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace webform
{
    public partial class EjemploConMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtNombre.Text = "Jeronimoooo";
            PokemonNegocio negocio = new PokemonNegocio();
            dgvPokemones.DataSource = negocio.listar();
            dgvPokemones.DataBind();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            lblNombre.Text = txtNombre.Text;
        }
    }
}