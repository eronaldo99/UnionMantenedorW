using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace UnionMantenedorW.Clases
{
    public class cIglesia
    {
        private int _Id;
        private int _S_ID;
        private int _DI_ID;
        private string _I_NOMBRE;
        private string _I_DIRECCION;
        private string _I_TELEFONO;
        private string _I_EMAIL;
        private string _I_MAPA;
        private string _I_IMAGEN;

        #region PROPIEDADES
        public int I_ID { get { return this._Id; } }
        public int S_ID { get { return this._S_ID; } }
        public int DI_ID { get { return this._DI_ID; } }
        public string I_NOMBRE { get { return this._I_NOMBRE; } }
        public string I_DIRECCION { get { return this._I_DIRECCION; } }
        public string I_TELEFONO { get { return this._I_TELEFONO; } }
        public string I_EMAIL { get { return this._I_EMAIL; } }
        public string I_MAPA { get { return this._I_MAPA; } }
        public string I_IMAGEN { get { return this._I_IMAGEN; } }
        #endregion

        public static cIglesia getIglesia(int pId)
        {
            return new cIglesia(pId);
        }

        private cIglesia(int pId)
        {
            using (DataTable dt = Funciones.ExecuteDataTable("select * from IGLESIA where I_ID=" + pId.ToString()))
            {
                if (dt.Rows.Count != 1) Funciones.fgError("Referencia inválida para cIGLESIA con pId " + pId.ToString());
                this._Id = pId;
                Funciones.AsignarDesdeDr(ref this._S_ID, dt.Rows[0], "S_ID");
                Funciones.AsignarDesdeDr(ref this._DI_ID, dt.Rows[0], "DI_ID");
                Funciones.AsignarDesdeDr(ref this._I_NOMBRE, dt.Rows[0], "I_NOMBRE");
                Funciones.AsignarDesdeDr(ref this._I_DIRECCION, dt.Rows[0], "I_DIRECCION");
                Funciones.AsignarDesdeDr(ref this._I_TELEFONO, dt.Rows[0], "I_TELEFONO");
                Funciones.AsignarDesdeDr(ref this._I_EMAIL, dt.Rows[0], "I_EMAIL");
                Funciones.AsignarDesdeDr(ref this._I_MAPA, dt.Rows[0], "I_MAPA");
                Funciones.AsignarDesdeDr(ref this._I_IMAGEN, dt.Rows[0], "I_IMAGEN");
            }
        }

        public cIglesia(int pDI_ID, string pI_NOMBRE, string pI_DIRECCION, string pI_TELEFONO, string pI_EMAIL, string pI_MAPA, string pI_IMAGEN)
        {
            //this._S_ID = pS_ID;
            this._DI_ID = pDI_ID;
            this._I_NOMBRE = pI_NOMBRE;
            this._I_DIRECCION = pI_DIRECCION;
            this._I_TELEFONO = pI_TELEFONO;
            this._I_EMAIL = pI_EMAIL;
            this._I_MAPA = pI_MAPA;
            this._I_IMAGEN = pI_IMAGEN;
            //this._Id = Funciones.ExecuteSqlIdentity("PA_IGLESIA_insert", this._D_ID, this._DI_ID, this._I_NOMBRE, this._I_DIRECCION, this._I_TELEFONO, this._I_EMAIL, this._I_MAPA, this._I_IMAGEN, this._Id);
        }
    }
}