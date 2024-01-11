using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Negocio;

namespace catalogoWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            UsuarioNegocio negocio = new UsuarioNegocio();

            try
            {
                if (Validacion.validaTextoVacio(txtUser) || Validacion.validaTextoVacio(txtPassword))
                {
                    Session.Add("error", "Debes completar ambos campos");
                    Response.Redirect("error.aspx"); //no le pongo el false porque sino va a continuar ejecutando
                }

                usuario = new Usuario(txtUser.Text, txtPassword.Text, false);
                if (negocio.Loguear(usuario))
                {
                    Session.Add("usuario", usuario);
                    bool admin = negocio.isAdmin(usuario);
                    Session.Add("admin", admin);
                    Response.Redirect("Home.aspx", false);
                }
                else
                {
                    Session.Add("error", "user o pass incorrectos");
                    Response.Redirect("Error.aspx");
                }

            }
           // catch (System.Threading.ThreadAbortException ex) { }
            catch (Exception ex)
            {
                if (!(ex is ThreadAbortException))
                {
                    Session.Add("error", ex.ToString());
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
    }
}