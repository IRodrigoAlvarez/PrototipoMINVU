using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMIN.HELPERS
{
    public class ControlErroresHelper
    {
        public static void GrabarExcepcion(string Ex_Formulario, string Ex_Procedimiento, string Ex_Mensaje)
        {
            try
            {
                string ruta_log = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\x64\\Release\\", "") + "\\Log";
                if (!Directory.Exists(ruta_log))
                    Directory.CreateDirectory(ruta_log);

                string Ex_Sistema = "PriorizadorInterConsultasHPH";
                string nombreArchivo = Ex_Sistema + "_" + Ex_Formulario + ".txt";
                string Lin_Archivo = Ex_Procedimiento + ";" + DateTime.Now.ToString("yyyy-MM-dd") + ";" + DateTime.Now.ToString("HH:mm:ss") + ";" + Ex_Mensaje + Environment.NewLine;
                File.AppendAllText(Path.Combine(ruta_log, nombreArchivo), Lin_Archivo);
            }
            catch
            {

            }
        }
    }
}
