using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace UnionMantenedorW.Clases
{
    public class cUsuario
    {
        private string _PK;
        private string _P_PK;
        private long _D_ID;
        private string _USR_NOMBRE;
        private string _USR_EMAIL;
        private string _USR_PASSWORD;
        private Funciones.tFecha _USR_FECHA_SISTEMA;
        private bool _USR_ACTIVO_SI_NO;

        #region PROPIEDADES
        public string PK { get { return this._PK; } }
        public string P_PK { get { return this._P_PK; } }
        public long D_ID { get { return this._D_ID; } }
        public string USR_NOMBRE { get { return this._USR_NOMBRE; } }
        public string USR_EMAIL { get { return this._USR_EMAIL; } }
        public string USR_PASSWORD { get { return this._USR_PASSWORD; } }
        public Funciones.tFecha USR_FECHA_SISTEMA { get { return this._USR_FECHA_SISTEMA; } }
        public bool USR_ACTIVO_SI_NO { get { return this._USR_ACTIVO_SI_NO; } }
        #endregion

        public static cUsuario getUsuario(string pPk)
        {
            if (!Funciones.ExecuteExisteEnBD("select top 1 1 from USUARIO where USR_PK='" + pPk + "'")) return null;
            return new cUsuario(pPk);
        }

        private cUsuario(string pPk)
        {
            using (DataTable dt = Funciones.ExecuteDataTable("SELECT * FROM USUARIO WHERE USR_PK='"+ pPk + "'" ))
            {
                if (dt.Rows.Count != 1) 
                {
                    Funciones.fgError("Referencia inválida para cUsuario con pk " + pPk);
                    return;
                }
                this._PK = pPk;
                Funciones.AsignarDesdeDr(ref this._P_PK, dt.Rows[0], "P_PK");
                Funciones.AsignarDesdeDr(ref this._D_ID, dt.Rows[0], "D_ID");
                Funciones.AsignarDesdeDr(ref this._USR_NOMBRE, dt.Rows[0], "USR_NOMBRE");
                Funciones.AsignarDesdeDr(ref this._USR_EMAIL, dt.Rows[0], "USR_EMAIL");
                Funciones.AsignarDesdeDr(ref this._USR_PASSWORD, dt.Rows[0], "USR_PASSWORD");
                Funciones.AsignarDesdeDr(ref this._USR_FECHA_SISTEMA, dt.Rows[0], "USR_FECHA_SISTEMA");
                Funciones.AsignarDesdeDr(ref this._USR_ACTIVO_SI_NO, dt.Rows[0], "USR_ACTIVO_SI_NO");
            }
        }
     
        public static bool Existe(string pPk)
        {
            return Funciones.ExecuteExisteEnBD("select top 1 1 from USUARIO where USR_PK='" + pPk + "'");
        }

        public static bool esValido(string pPk, string pPassrword,ref string pErr)
        {
            
            if (!Funciones.ExecuteExisteEnBD("select TOP 1 1 FROM USUARIO WHERE USR_PK='" + pPk + "' AND UPPER(USR_PASSWORD)='" + pPassrword.ToUpper() + "' AND USR_ACTIVO_SI_NO=1"))
            {
                pErr = "Nombre de usario inválido o clave incorrecta";
                return false;
            }
            cUsuario aux = cUsuario.getUsuario(pPk);
            return true;
        }
        public DataTable Siniestros()
        {
            return Funciones.ExecuteDataTable("PA_EXTRANET_SINIESTROS", this._PK);
        }
        public string CambiarClave(string pNuevaClave,string pClaveVieja)
        {
            string pErr = string.Empty;
            if (string.IsNullOrEmpty(pClaveVieja))
                pErr = "Debe ingresar su clave actual";
            else if (this._USR_PASSWORD.ToUpper() != pClaveVieja.ToUpper())
                 pErr = "Clave actual es inválida";
            else if(this._USR_PASSWORD.ToUpper()== pNuevaClave.ToUpper())
                pErr = "Clave nueva es igual a la anterior";
            else if(pNuevaClave.Length<4)
                pErr = "Clave nueva debe tener al menos 4 caracteres";
            if (!string.IsNullOrEmpty(pErr))
                return pErr;
            Funciones.ExecuteSql("UPDATE usuarIO SET USR_PASSWORD='" + pNuevaClave.ToUpper() +"' WHERE USR_PK='"+ this._PK +"'");
            return "Clave modificada satisfactoriamente";
        }
        public string RecuperarCorreo()
        {
            string pErr = string.Empty;
            Funciones.EnviarEmailPorBD("Su clave de acceso es " + this._USR_PASSWORD, "Iglesia Adventista del Séptimo Día - Recuperación de clave de acceso web", this._USR_EMAIL, string.Empty, string.Empty, ref pErr);
            if (!string.IsNullOrEmpty(pErr)) return pErr;
            string auxCuerpo = (this._USR_EMAIL.Split('@'))[0];
            string auxCorreo = (this._USR_EMAIL.Split('@'))[1];
            string auxCuerpoX = auxCuerpo.Substring((auxCuerpo.Length / 2), auxCuerpo.Length - (auxCuerpo.Length / 2));
            string auxCuerpoY = "X";
            for (int i = 1; i < auxCuerpoX.Length; i++)
            {
                auxCuerpoY += "X";
            }
            return "Se envió correo con su clave a " + auxCuerpo.Replace(auxCuerpoX, auxCuerpoY) +"@" + auxCorreo;
        }
    }
}
