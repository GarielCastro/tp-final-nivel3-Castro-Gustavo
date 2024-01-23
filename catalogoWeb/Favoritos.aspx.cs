using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace catalogoWeb
{
    public partial class Favoritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Articulo> lista = (List<Articulo>)Session["favoritos"];
                dgvFavoritos.DataSource = lista;
                dgvFavoritos.DataBind();
        }
    }
}