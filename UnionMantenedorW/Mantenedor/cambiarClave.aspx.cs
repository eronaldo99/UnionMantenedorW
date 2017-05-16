using UnionMantenedorW.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnionMantenedorW.Mantenedor
{
    public partial class cambiarClave : System.Web.UI.Page
    {
        private cUsuario _Usuario;

        private cUsuario Usuario
        {
            get { return Funciones.fzUsuarioGet(this.Session, ref this._Usuario, this.Page.User); }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (this.clave_nueva.Text != this.clave_nueva2.Text)
            {
                this.lblMsj.Text = "Claves nuevas no coinciden";
                return;
            }
            this.lblMsj.Text = this.Usuario.CambiarClave(this.clave_nueva.Text.Trim(),this.clave_vieja.Text);
        }
    }
}