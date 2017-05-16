using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace UnionMantenedorW.Clases
{
    public class cSede
    {
        private int _Id;
        private int _U_ID;
        private string _S_TIPO;
        private string _S_NOMBRE;
        private string _S_TELEFONO;
        private string _S_EMAIL;
        private string _S_SITIO_WEB;
        private string _S_DIRECCION;
        private string _S_MAPA;
        private string _S_IMAGEN;

        #region PROPIEDADES
        public int S_ID { get { return this._Id; } }
        public int U_ID { get { return this._U_ID; } }
        public string S_TIPO { get { return this._S_TIPO; } }
        public string S_NOMBRE { get { return this._S_NOMBRE; } }
        public string S_TELEFONO { get { return this._S_TELEFONO; } }
        public string S_EMAIL { get { return this._S_EMAIL; } }
        public string S_SITIO_WEB { get { return this._S_SITIO_WEB; } }
        public string S_DIRECCION { get { return this._S_DIRECCION; } }
        public string S_MAPA { get { return this._S_MAPA; } }
        public string S_IMAGEN { get { return this._S_IMAGEN; } }
        #endregion

        public static cSede getSede(int pId)
        {
            return new cSede(pId);
        }

        private cSede(int pId)
        {
            using (DataTable dt = Funciones.ExecuteDataTable("select * from SEDE where S_ID=" + pId.ToString()))
            {
                if (dt.Rows.Count != 1) Funciones.fgError("Referencia inválida para cSEDE con pId " + pId.ToString());
                this._Id = pId;
                Funciones.AsignarDesdeDr(ref this._U_ID, dt.Rows[0], "U_ID");
                Funciones.AsignarDesdeDr(ref this._S_TIPO, dt.Rows[0], "S_TIPO");
                Funciones.AsignarDesdeDr(ref this._S_NOMBRE, dt.Rows[0], "S_NOMBRE");
                Funciones.AsignarDesdeDr(ref this._S_TELEFONO, dt.Rows[0], "S_TELEFONO");
                Funciones.AsignarDesdeDr(ref this._S_EMAIL, dt.Rows[0], "S_EMAIL");
                Funciones.AsignarDesdeDr(ref this._S_SITIO_WEB, dt.Rows[0], "S_SITIO_WEB");
                Funciones.AsignarDesdeDr(ref this._S_DIRECCION, dt.Rows[0], "S_DIRECCION");
                Funciones.AsignarDesdeDr(ref this._S_MAPA, dt.Rows[0], "S_MAPA");
                Funciones.AsignarDesdeDr(ref this._S_IMAGEN, dt.Rows[0], "S_IMAGEN");
            }
        }

        public cSede(int pU_ID, string pS_TIPO, string pS_NOMBRE, string pS_TELEFONO, string pS_EMAIL, string pS_SITIO_WEB, string pS_DIRECCION, string pS_MAPA, string pS_IMAGEN)
        {
            this._U_ID = pU_ID;
            this._S_TIPO = pS_TIPO;
            this._S_NOMBRE = pS_NOMBRE;
            this._S_TELEFONO = pS_TELEFONO;
            this._S_EMAIL = pS_EMAIL;
            this._S_SITIO_WEB = pS_SITIO_WEB;
            this._S_DIRECCION = pS_DIRECCION;
            this._S_MAPA = pS_MAPA;
            this._S_IMAGEN = pS_IMAGEN;
            this._Id = Funciones.ExecuteSqlIdentity("PA_SEDE_insert", this._U_ID, this._S_TIPO, this._S_NOMBRE, this._S_TELEFONO, this._S_EMAIL, this._S_SITIO_WEB, this._S_DIRECCION, this._S_MAPA, this._S_IMAGEN, this._Id);
        }
    }
}