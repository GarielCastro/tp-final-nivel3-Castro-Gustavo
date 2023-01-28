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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                if (!IsPostBack+)
                {
                    List<Articulo> listaArticulo = negocio.listarconSP();
                    Session["listaArticulo"] = listaArticulo;

                    List<Marca> listaMarca = marcaNegocio.listar();
                    ddlMarca.DataSource = listaMarca;
                    ddlMarca.DataTextField = "Descripcion";
                    ddlMarca.DataBind();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            Articulo nuevo = new Articulo();
            nuevo.Codigo = txtCodigo.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Marca.Id = ddlMarca.SelectedIndex;
            negocio.agregar(nuevo);


        }
        protected void ddlMarca_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int id = int.Parse(ddlMarca.SelectedItem.Value);
            ddlCategoriaFiltrados.DataSource = ((List<Articulo>)Session["listaArticulo"]).FindAll(x => x.Marca.Id == id);
            ddlCategoriaFiltrados.DataBind();
        }
    }
}