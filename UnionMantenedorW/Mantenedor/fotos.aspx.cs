using UnionMantenedorW.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnionMantenedorW.Mantenedor
{
    public partial class fotos : System.Web.UI.Page
    {
        //private cSiniestro _Siniestro;
        //private cUsuario _Usuario;

        //private cUsuario Usuario
        //{
        //    get { return Funciones.fzUsuarioGet(this.Session, ref this._Usuario, this.Page.User); }
        //}
        //private cSiniestro Siniestro
        //{
        //    get
        //    {
        //        if (this._Siniestro == null)
        //        {
        //            if (this.Session["SINIESTRO"] == null || ((cSiniestro)this.Session["SINIESTRO"]).Id != this.RequestSiniestroId)
        //            {
        //                this.Session["SINIESTRO"] = cSiniestro.getSiniestro(this.RequestSiniestroId);
        //            }
        //            this._Siniestro = (cSiniestro)this.Session["SINIESTRO"];
        //        }
        //        return this._Siniestro;
        //    }
        //}
        //private int RequestSiniestroId
        //{
        //    get { return int.Parse(this.Request.QueryString["S_ID"]); }
        //}
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (Page.IsPostBack) return;
        //    this.cargarRptFotos();
        //}
        //private void cargarRptFotos()
        //{
        //    this.rptFotos.DataSource = this.Siniestro.FotosDeInmueble(this.Request);
        //    this.rptFotos.DataBind(); 
        //}
    }
}