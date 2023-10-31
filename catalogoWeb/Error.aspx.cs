using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace catalogoWeb
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["error"] != null)
                lblMensaje.Text = Session["error"].ToString();
            if (!this.IsPostBack)
                this.ViewState["paginaorigen"] = Request.UrlReferrer.ToString();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect((string)this.ViewState["paginaorigen"]);
        }
    }
}