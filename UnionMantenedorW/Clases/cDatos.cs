using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnionMantenedorW.Clases
{
    public class cDatos
    {
        public static string ArchivosDirectorioPublico()
        {
            return System.Configuration.ConfigurationManager.AppSettings["ArchivosDirectorioPublico"];
        }
        public static string ArchivosDirectorioPrivado()
        {
            return System.Configuration.ConfigurationManager.AppSettings["ArchivosDirectorioPrivado"];
        }
        public static string EmailContactoDestino()
        {
            return System.Configuration.ConfigurationManager.AppSettings["EmailContactoDestino"];
        }
        public static string ArchivosPasoAbsoluto()
        {
            return System.Configuration.ConfigurationManager.AppSettings["ArchivosPasoAbsoluto"];
        }
        public static string ArchivosPasoRelativo()
        {
            return System.Configuration.ConfigurationManager.AppSettings["ArchivosPasoRelativo"];
        }
    }
}