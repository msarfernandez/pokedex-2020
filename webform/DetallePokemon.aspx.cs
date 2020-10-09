using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform
{
    public partial class DetallePokemon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pokemon seleccionado = ((List<Pokemon>)Session["listado"])[0];
            lblNombre.Text = seleccionado.Nombre;
        }
    }
}