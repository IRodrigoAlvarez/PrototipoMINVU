using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PSMIN.HELPERS
{
    public class ConfigurationHelper
    {
        public static string ObtenerConfiguracion(String NombreConfiguracion)
        {
            var resultado = ConfigurationManager.AppSettings[NombreConfiguracion];
            return resultado;
        }

        public static string ObtenerConnectionString(String NombreConnectionString)
        {
            var resultado = ConfigurationManager.ConnectionStrings[NombreConnectionString].ConnectionString;
            return resultado;
        }
    }
}
