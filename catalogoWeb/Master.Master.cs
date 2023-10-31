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
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            imgAvatar.ImageUrl = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png";
            if (!(Page is Default || Page is Registro || Page is Login || Page is Logout || Page is Error)&& !IsPostBack)
            {
                if (!Seguridad.sesionActiva(Session["usuario"]))
                    Response.Redirect("Login.aspx", false);
                else
                {
                    Usuario user = (Usuario)Session["usuario"];
                    lblUser.Text = user.Correo;
                    if (!string.IsNullOrEmpty(user.imagenPerfil))
                        imgAvatar.ImageUrl = "~/Images/" + user.imagenPerfil;
                    else imgAvatar.ImageUrl = "https://www.palomacornejo.com/wp-content/uploads/2021/08/no-image.jpg";

                }
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}