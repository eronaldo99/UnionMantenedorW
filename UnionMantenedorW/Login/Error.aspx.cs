using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UnionMantenedorW.Clases;

namespace Ekatours.Login
{
    public partial class Error : System.Web.UI.Page
    {
        private cUsuario _Usuario;

        private cUsuario Usuario
        {
            get { return Funciones.fzUsuarioGet(this.Session, ref this._Usuario, this.Page.User); }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
           // this.btnVolver.PostBackUrl = this.Usuario.UrlInicio;
        }
    }
}