using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace UnionMantenedorW.Clases
{
    public class cNoticia
    {
        private long _Id;
        private long _D_ID;
        private string _N_TITULO;
        private string _N_IMAGEN;
        private string _N_IMAGEN_REFERECIA;
        private string _USR_PK;
        private Funciones.tFecha _N_FECHA_SISTEMA;

        #region PROPIEDADES
        public long Id { get { return this._Id; } }
        public long D_ID { get { return this._D_ID; } }
        public string N_TITULO { get { return this._N_TITULO; } }
        public string N_IMAGEN { get { return this._N_IMAGEN; } }
        public string N_IMAGEN_REFERECIA { get { return this._N_IMAGEN_REFERECIA; } }
        public string USR_PK { get { return this._USR_PK; } }
        public Funciones.tFecha N_FECHA_SISTEMA { get { return this._N_FECHA_SISTEMA; } }
        #endregion

        public static cNoticia getNoticia(long pId)
        {
            return new cNoticia(pId);
        }

        private cNoticia(long pId)
        {
            using (DataTable dt = Funciones.ExecuteDataTable("select * from NOTICIA where N_ID=" + pId.ToString()))
            {
                if (dt.Rows.Count != 1) Funciones.fgError("Referencia inválida para cNOTICIA con pId " + pId.ToString());
                this._Id = pId;
                Funciones.AsignarDesdeDr(ref this._D_ID, dt.Rows[0], "D_ID");
                Funciones.AsignarDesdeDr(ref this._N_TITULO, dt.Rows[0], "N_TITULO");
                Funciones.AsignarDesdeDr(ref this._N_IMAGEN, dt.Rows[0], "N_IMAGEN");
                Funciones.AsignarDesdeDr(ref this._N_IMAGEN_REFERECIA, dt.Rows[0], "N_IMAGEN_REFERECIA");
                Funciones.AsignarDesdeDr(ref this._USR_PK, dt.Rows[0], "USR_PK");
                Funciones.AsignarDesdeDr(ref this._N_FECHA_SISTEMA, dt.Rows[0], "N_FECHA_SISTEMA");
            }
        }

        public cNoticia(long pD_ID, string pN_TITULO, string pN_IMAGEN, string pN_IMAGEN_REFERECIA, string pUSR_PK, Funciones.tFecha pN_FECHA_SISTEMA)
        {
            this._D_ID = pD_ID;
            this._N_TITULO = pN_TITULO;
            this._N_IMAGEN = pN_IMAGEN;
            this._N_IMAGEN_REFERECIA = pN_IMAGEN_REFERECIA;
            this._USR_PK = pUSR_PK;
            this._N_FECHA_SISTEMA = pN_FECHA_SISTEMA;
            this._Id = Funciones.ExecuteSqlIdentity("PA_NOTICIA_insert", this._D_ID, this._N_TITULO, this._N_IMAGEN, this._N_IMAGEN_REFERECIA, this._USR_PK, this._N_FECHA_SISTEMA.Fecha, this._Id);
        }
    }
}