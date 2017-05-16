using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UnionMantenedorW.Clases;
using System.Web.Security;

namespace UnionMantenedorW.Login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string auxErr = string.Empty;
            //if (!cUsuario.esValido(this.txbNombreUsuario.Text.Trim(), this.txbPassword.Text.Trim(),this.Request,ref auxErr))
            //{
            //    this.lblMsj.Text = auxErr;
            //    return;
            //}
            //cUsuario aux = cUsuario.getUsuario(this.txbNombreUsuario.Text.Trim());
            //this.Session["USUARIO"] = aux;
            //FormsAuthentication.RedirectFromLoginPage(this.txbNombreUsuario.Text.Trim(), true);
            //Response.Redirect(aux.UrlInicio);
        }
    }
}