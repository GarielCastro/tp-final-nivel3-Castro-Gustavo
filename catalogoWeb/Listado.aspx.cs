using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Modelo;

namespace catalogoWeb
{
    public partial class Listado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Session["usuario"] == null)
                    {
                        Session.Add("error", "Debes loguearte para ingresar");
                        Response.Redirect("Error.aspx", false);
                    }
                    else
                    {
                        if ((bool)Session["admin"] == true)
                        {
                            ArticuloNegocio negocio = new ArticuloNegocio();
                            Session.Add("Listado", negocio.listarconSP());  //traigo la lista de la base de datos y la cargo en sesión
                            dgvArticulos.DataSource = Session["Listado"];
                            dgvArticulos.DataBind();
                        }
                        else
                        {
                            Session.Add("error", "Debes ser administrador para ingresar aquí");
                            Response.Redirect("Error.aspx", false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx", false);
            }

        }

        protected void dgvArticulos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvArticulos.DataSource = Session["Listado"];
            dgvArticulos.PageIndex = e.NewPageIndex;
            dgvArticulos.DataBind();
        }

        protected void dgvArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvArticulos.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioArticulo.aspx?id=" + id);
        }
    }


}
