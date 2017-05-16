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
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cUsuario usuario = (cUsuario)this.Session["USUARIO"];
            this.Session["USUARIO"] = null;
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            Funciones.tFecha fechaAux = new Funciones.tFecha(DateTime.Today);
            fechaAux.Sumar(Funciones.tFecha.eUnidadFecha.Dia, -1);
            Context.Response.Cookies[FormsAuthentication.FormsCookieName].Expires = fechaAux.Fecha;
            Response.Redirect("~/Login/login.aspx");
        }
    }
}