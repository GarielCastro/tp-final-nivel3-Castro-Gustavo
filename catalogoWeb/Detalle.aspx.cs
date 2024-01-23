using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Negocio;

namespace catalogoWeb
{
    public partial class Detalle : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.listar(id);
            try
            {
                Articulo enDetalle = ListaArticulo[0];
                imgDetalle.ImageUrl = enDetalle.UrlImagen;
                lblNombre.Text = enDetalle.Nombre;
                lblDescripcion.Text = enDetalle.Descripcion;
                lblCodigo.Text = enDetalle.Codigo;
                lblPrecio.Text = enDetalle.Precio.ToString();
                Session.Add("enDetalle", enDetalle);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx", false);
            }

        }

        protected void btnFavorito_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFav = (List<Articulo>)Session["favoritos"];
            listaFav.Add((Articulo)Session["enDetalle"]);
            Session.Add("favoritos", listaFav);
        }
    }
}