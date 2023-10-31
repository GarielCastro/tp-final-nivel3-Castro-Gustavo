using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace catalogoWeb
{
    public partial class MiPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Seguridad.sesionActiva(Session["usuario"]))
                Response.Redirect("login.aspx", false);
            else
            {
                if (!IsPostBack)
                {

                    Usuario logueado = (Usuario)Session["usuario"];
                    try
                    {
                        txtId.Text = ((int)logueado.Id).ToString();
                        txtMail.Text = logueado.Correo;
                        txtNombre.Text = logueado.Nombre;
                        txtApellido.Text = logueado.Apellido;
                        imgNuevoPerfil.ImageUrl = "~/Images/" + logueado.imagenPerfil;
                    }
                    catch (Exception ex)
                    {
                        Session.Add("error", ex);
                        Response.Redirect("error.aspx");
                    }
                }
            }


        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio negocio = new UsuarioNegocio();
                Usuario userModificado = (Usuario)Session["usuario"];

                //escribir img si es que se cargó
                if (txtImagen.PostedFile.FileName != "")

                {   //Primero recupero la ruta donde se guardan las imagenes
                    string ruta = Server.MapPath("./Images/");
                    
                    //guardo la imagen en esa ruta    
                    txtImagen.PostedFile.SaveAs(ruta + "perfil-" + userModificado.Id + ".jpg");
                    userModificado.imagenPerfil = "perfil-" + userModificado.Id + ".jpg";
                }
              //  else
              //      imgNuevoPerfil.ImageUrl = "https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg";

                userModificado.Id = int.Parse(txtId.Text);
                userModificado.Nombre = txtNombre.Text;
                userModificado.Apellido = txtApellido.Text;
              //  userModificado.imagenPerfil = "perfil-" + userModificado.Id + ".jpg";
                negocio.actualizar(userModificado);
                Session.Add("usuario", userModificado);
                txtNombre.Text = userModificado.Nombre.ToString();


                // leer imagen para cargarla en el avatar de la master page
                Image img = (Image)Master.FindControl("imgAvatar");
                img.ImageUrl = "~/Images/" + userModificado.imagenPerfil;


            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx", false);

            }
        }
    }
}