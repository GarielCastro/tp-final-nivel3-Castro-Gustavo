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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtConfirmaPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword != txtConfirmaPassword)
                Session.Add("error", "Las contraseñas no coinciden");
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevo = new Usuario(txtUser.Text, txtPassword.Text, false);
                UsuarioNegocio negocio = new UsuarioNegocio();
                EmailService emailService = new EmailService();
                nuevo.Id = negocio.insertarUsuario(nuevo);  //acá aplico el metodo de insertar y recupero el id nuevo
                Session.Add("usuario", nuevo);

                emailService.armarCorreo(nuevo.Correo, "Registro exitoso", "Hola te damos la bienvenida a la app");
                emailService.enviarMail();
                Response.Redirect("Home.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx", false);
            }
        }
    }
}