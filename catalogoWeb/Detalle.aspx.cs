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
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.listarconSP();
            try
            {
                if (!IsPostBack)
                {
                    //    repRepetidor.DataSource = ListaArticulo;
                    //  repRepetidor.DataBind();

                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx", false);
            }

        }
    }
}