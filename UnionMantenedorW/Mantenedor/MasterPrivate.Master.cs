using UnionMantenedorW.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnionMantenedorW.Mantenedor
{
    public partial class MasterPrivate : System.Web.UI.MasterPage
    {
        private cUsuario _Usuario;
        private cUsuario Usuario
        {
            get { return Funciones.fzUsuarioGet(this.Session, ref this._Usuario, this.Page.User); }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            //this.lblUsuario.Text = this.Usuario.Nombre;
            //this.cargarMenu();
        }
        private void cargarMenu()
        {
            StringBuilder sb = new StringBuilder();
            using (DataTable dt = this.Usuario.Siniestros())
            {
                sb.Append("<ul>");
                foreach (DataRow row in dt.Rows)
                {
                    sb.AppendFormat("<li><a href=\"siniestro.aspx?s_id={0}\">Siniestro {0}</a></li>",row["CR_ID"].ToString());
                    sb.AppendFormat("<li><a href=\"fotos.aspx?s_id={0}\">Fotos de Inmueble {0}</a></li>", row["CR_ID"].ToString());
                }
                sb.Append("</ul>");
            }
            this.liMenu.Text = sb.ToString();
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/logout.aspx");
        }
    }
}