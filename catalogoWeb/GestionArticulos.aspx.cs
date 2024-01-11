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
            bool admin = (bool)Session["admin"];
            if (admin)
            {
                try
                {
                    if (!IsPostBack)
                    {   //cargo el menu de marcas
                        MarcaNegocio negocioMarca = new MarcaNegocio();
                        List<Marca> listamarca = negocioMarca.listar();
                        ddlMarca.DataSource = listamarca;
                        ddlMarca.DataValueField = "Id";
                        ddlMarca.DataTextField = "Descripcion";
                        ddlMarca.DataBind();

                        CategoriaNegocio negocioCat = new CategoriaNegocio();
                        List<Categoria> listaCat = negocioCat.listar();
                        ddlCategoria.DataSource = listaCat;
                        ddlCategoria.DataValueField = "Id";
                        ddlCategoria.DataTextField = "Descripcion";
                        ddlCategoria.DataBind();
                    }
                    // Para modificar pregunto si llegó un id
                    string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
                    if (id != "" && !IsPostBack)
                    {
                        ArticuloNegocio negocio = new ArticuloNegocio();
                        Articulo seleccionado = (negocio.listar(id))[0];
                        Session.Add("ArticuloSeleccionado", seleccionado);
                        //cargo los campos con el articulo seleccionado

                        txtCodigo.Text = seleccionado.Codigo;
                        txtDescripcion.Text = seleccionado.Descripcion;
                        txtNombre.Text = seleccionado.Nombre;
                        txtImagen.Text = seleccionado.UrlImagen;
                        ddlMarca.SelectedValue = seleccionado.Marca.Id.ToString();
                        ddlCategoria.SelectedValue = seleccionado.Categoria.Id.ToString();
                        txtImagen_TextChanged(sender, e);
                        //ddlMarca.SelectedIndex = ddlMarca.Items.IndexOf(ddlMarca.Items.FindByValue(seleccionado.Marca.Id.ToString()));
                    }


                }
                catch (Exception ex)
                {

                    Session.Add("error", ex.ToString());
                    Response.Redirect("error.aspx", false);
                }
                //Articulo nuevo = new Articulo();
                //nuevo.Codigo = txtCodigo.Text;
                //nuevo.Descripcion = txtDescripcion.Text;
                //nuevo.Marca.Id = ddlMarca.SelectedIndex;
                //negocio.agregarConSP(nuevo);

            }

        }
        protected void ddlMarca_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int id = int.Parse(ddlMarca.SelectedItem.Value);
            ddlCategoriaFiltrados.DataSource = ((List<Articulo>)Session["listaArticulo"]).FindAll(x => x.Marca.Id == id);
            ddlCategoriaFiltrados.DataBind();
        }

        protected void txtImagen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}