using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace UnionMantenedorW.Clases
{
    public class cDepartamento
    {
        private long _Id;
        private int _I_ID;
        private string _DT_PK;
        private string _D_RESPONSABLE;
        private string _D_IMAGEN;
        private string _D_EMAIL;
        private string _D_TELEFONO;

        #region PROPIEDADES
        public long Id { get { return this._Id; } }
        public int I_ID { get { return this._I_ID; } }
        public string DT_PK { get { return this._DT_PK; } }
        public string D_RESPONSABLE { get { return this._D_RESPONSABLE; } }
        public string D_IMAGEN { get { return this._D_IMAGEN; } }
        public string D_EMAIL { get { return this._D_EMAIL; } }
        public string D_TELEFONO { get { return this._D_TELEFONO; } }
        #endregion

        public static cDepartamento getDepartamento(long pId)
        {
            return new cDepartamento(pId);
        }

        private cDepartamento(long pId)
        {
            using (DataTable dt = Funciones.ExecuteDataTable("select * from DEPARTAMENTO where D_ID=" + pId.ToString()))
            {
                if (dt.Rows.Count != 1) Funciones.fgError("Referencia inválida para cDEPARTAMENTO con pId " + pId.ToString());
                this._Id = pId;
                Funciones.AsignarDesdeDr(ref this._I_ID, dt.Rows[0], "I_ID");
                Funciones.AsignarDesdeDr(ref this._DT_PK, dt.Rows[0], "DT_PK");
                Funciones.AsignarDesdeDr(ref this._D_RESPONSABLE, dt.Rows[0], "D_RESPONSABLE");
                Funciones.AsignarDesdeDr(ref this._D_IMAGEN, dt.Rows[0], "D_IMAGEN");
                Funciones.AsignarDesdeDr(ref this._D_EMAIL, dt.Rows[0], "D_EMAIL");
                Funciones.AsignarDesdeDr(ref this._D_TELEFONO, dt.Rows[0], "D_TELEFONO");
            }
        }

        public cDepartamento(int pI_ID, string pDT_PK, string pD_RESPONSABLE, string pD_IMAGEN, string pD_EMAIL, string pD_TELEFONO)
        {
            this._I_ID = pI_ID;
            this._DT_PK = pDT_PK;
            this._D_RESPONSABLE = pD_RESPONSABLE;
            this._D_IMAGEN = pD_IMAGEN;
            this._D_EMAIL = pD_EMAIL;
            this._D_TELEFONO = pD_TELEFONO;
            this._Id = Funciones.ExecuteSqlIdentity("PA_DEPARTAMENTO_insert", this._I_ID, this._DT_PK, this._D_RESPONSABLE, this._D_IMAGEN, this._D_EMAIL, this._D_TELEFONO, this._Id);
        }
    }
}