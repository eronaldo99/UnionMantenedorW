using UnionMantenedorW.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnionMantenedorW.Mantenedor
{
    public partial class contacto : System.Web.UI.Page
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
            string pErr = string.Empty;
            if (!this.Validar(ref pErr))
            {
                this.lblMsj.Text = pErr;
                return;
            }
            string auxAsunto = "Contacto desde Extranet [CLIENTE] - " + this.Usuario.USR_NOMBRE;
            StringBuilder auxCuerpo = new StringBuilder();
            auxCuerpo.Append("<h5>Mensaje de Cliente:</h5>");
            auxCuerpo.Append("<table>");
            auxCuerpo.AppendFormat("<tr><td style=\"font-weight:bold;\">Nombre</td><td>: {0}</td></tr>", this.Usuario.USR_NOMBRE);
            auxCuerpo.AppendFormat("<tr><td style=\"font-weight:bold;\">Correo</td><td>: {0}</td></tr>", this.Usuario.USR_EMAIL);
            //auxCuerpo.AppendFormat("<tr><td style=\"font-weight:bold;\">Teléfono/Celular</td><td>: {0}</td></tr>", this.txbFono.Text.Trim());
            auxCuerpo.AppendFormat("<tr><td style=\"font-weight:bold;vertical-align:top;\">Mensaje</td><td>: {0}</td></tr>", this.txbMsj.Text.Trim().Replace("\r\n", "<br />"));
            auxCuerpo.Append("</table>");
            Funciones.EnviarEmailPorBD(auxCuerpo.ToString(), auxAsunto, cDatos.EmailContactoDestino(), string.Empty, string.Empty, ref pErr);
            if (!string.IsNullOrEmpty(pErr))
                this.lblMsj.Text = "Ocurrio un error al enviar el mensaje: " + pErr;
            else
            {
                this.lblMsj.Text = "Mensaje enviado satisfactoriamente";
                this.limpiarForm();
            }
        }
        private bool Validar(ref string pErr)
        {
            if (string.IsNullOrEmpty(this.txbAsunto.Text)) pErr = "Debe ingresar nombre";
            if (string.IsNullOrEmpty(this.txbMsj.Text)) pErr = "Debe ingresar un mensaje";
            return string.IsNullOrEmpty(pErr);
        }
        private void limpiarForm()
        {
            this.txbAsunto.Text = string.Empty;
            this.txbMsj.Text = string.Empty;
        }
    }
}