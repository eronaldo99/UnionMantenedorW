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
    public partial class siniestro : System.Web.UI.Page
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
        private int RequestSiniestroId
        {
            get { return int.Parse(this.Request.QueryString["S_ID"]); }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.GestionaPostBack();
            ////aca validar que solo el usuario pueda ver su siniestro
            //if (Page.IsPostBack) return;
            //this.cargarDatosEncabezado();
            //this.cargarRptLineaTiempo();
        }
        //private void GestionaPostBack()
        //{
        //    if (! string.IsNullOrEmpty(this.Request.Params["__EVENTTARGET"] ))
        //    {
        //        if (this.Request.Params["__EVENTTARGET"].Contains("verArchivo"))
        //        {
        //            string argument = Request.Params["__EVENTARGUMENT"];
        //            //aca extension fileinfo
        //            string aux = cSiniestro.ArchivoRecuperar(double.Parse((argument.Split('|'))[0]), (argument.Split('|'))[1],cDatos.ArchivosDirectorioPublico());
        //            Funciones.DownloadFile(aux, true, this.Response);
        //        }
        //    }
        //}
        //private void cargarDatosEncabezado()
        //{
        //    this.lblCia.Text = this.Siniestro.Compania;
        //    this.lblEstado.Text = this.Siniestro.Estado;
        //    this.lblEstadoFecha.Text = this.Siniestro.EstadoFecha.MostrarPantalla();
        //    this.lblEtapa.Text = this.Siniestro.Etapa;
        //    this.lblSiniestroId.Text = this.Siniestro.Id.ToString();
        //    this.lblTipo.Text = this.Siniestro.Tipo;
        //    this.lblFechaSistema.Text = this.Siniestro.FechaSistema.MostrarComo11deMayode2012();
        //}
        //private void cargarRptLineaTiempo()
        //{
        //    this.rptLineaTiempo.DataSource =this.Siniestro.LineaTiempo();
        //    this.rptLineaTiempo.DataBind();
        //}

        //protected void rptLineaTiempo_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        //    {
        //        Literal auxDocs= (Literal)e.Item.FindControl("liDocs");
        //        StringBuilder auxHtml = new StringBuilder();
        //        using (DataTable dt = cSiniestro.ActividadDocumentos(int.Parse(DataBinder.Eval(e.Item.DataItem, "cd_id").ToString())))
        //        {
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                auxHtml.AppendFormat("<p><img src ='imag/clip.gif' onclick ='{0}' /><a href ='#' onclick ='{0}' >{1}</a></p>", "javascript:__doPostBack(\"verArchivo\",\""+ row["CA_ID"].ToString() + "|" + row["CA_NOMBRE"].ToString() + "\");", row["CDA_NOMBRE"].ToString());
        //            }
        //        }
        //        if (auxHtml.Length > 10)
        //            auxDocs.Text = auxHtml.ToString();
        //    }
        //}
    }
}