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
    public partial class FormularioArticulo : System.Web.UI.Page
    {
        public bool ConfirmaEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            try
            {
                if (!IsPostBack)
                {   //cargo el menu de marcas
                    MarcaNegocio negocio = new MarcaNegocio();
                    List<Marca> listamarca = negocio.listar();
                    ddlMarca.DataSource = listamarca;
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Descripcion";
                    ddlMarca.DataBind();
                    
                    CategoriaNegocio negociocat = new CategoriaNegocio();
                    List<Categoria> listaCat = negociocat.listar();
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
                    txtImagenrl.Text = seleccionado.UrlImagen;
                    ddlMarca.SelectedValue = seleccionado.Marca.Id.ToString();
                    ddlCategoria.SelectedValue = seleccionado.Categoria.Id.ToString();
                    txtPrecio.Text = seleccionado.Precio.ToString();
                    txtImagenrl_TextChanged(sender, e);
                    //ddlMarca.SelectedIndex = ddlMarca.Items.IndexOf(ddlMarca.Items.FindByValue(seleccionado.Marca.Id.ToString()));
                }
               
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx", false);
            }

        }

         protected void txtImagenrl_TextChanged(object sender, EventArgs e)
        {
            imgArticulo.ImageUrl = txtImagenrl.Text;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo nuevo = new Articulo();
                ArticuloNegocio negocio = new ArticuloNegocio();
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Marca = new Marca();
                nuevo.Marca.Id = int.Parse(ddlMarca.SelectedValue);
                nuevo.Categoria = new Categoria();
                nuevo.Categoria.Id = int.Parse(ddlCategoria.SelectedValue);
                nuevo.UrlImagen = txtImagenrl.Text;
                nuevo.Precio = int.Parse(txtPrecio.Text.ToString());

                if (Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(Request.QueryString["id"]);
                    negocio.modificarArticulo(nuevo);
                }
                else
                    negocio.agregarConSP(nuevo);

                Response.Redirect("Listado.aspx", false);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
                Response.Redirect("error.aspx", false);      //redireccion a pantalla de error


            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ConfirmaEliminacion = true;
        }

        protected void btnConfirmaEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkConfirmaEliminar.Checked)
                {
                    Articulo aBorrar = new Articulo();
                    aBorrar.Id = int.Parse(Request.QueryString["id"]);
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    negocio.eliminar(aBorrar.Id);
                    Response.Redirect("Listado.aspx");
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
                Response.Redirect("error.aspx", false);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Listado.aspx", false);
        }
    }
}