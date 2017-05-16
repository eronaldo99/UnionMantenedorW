using UnionMantenedorW.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnionMantenedorW.Mantenedor
{
    public partial class perfil : System.Web.UI.Page
    {
        private cUsuario _Usuario;
        private cUsuario Usuario
        {
            get { return Funciones.fzUsuarioGet(this.Session, ref this._Usuario, this.Page.User); }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            //this.lblComuna.Text = this.Usuario.Comuna;
            //this.lblDireccion.Text = this.Usuario.Direccion;
            //this.lblEmail.Text = this.Usuario.Email;
            //this.lblNombre.Text = this.Usuario.Nombre;
            //this.lblRegion.Text = this.Usuario.Region;
            //this.lblRUT.Text = this.Usuario.RUTCompleto.MostrarPantalla();
            //this.lblFono.Text = this.Usuario.Fonos;
        }
    }
}