using CapaDatosBO;
using CapaDatosNEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrototipoMINVU.Models
{
    public class Sistemas
    {
        public int idSistemas { get; set; }
        public string NombreSistemas { get; set; }
        public List<SistemasBO> ListaSistemas { get; set; }
        

        public void CargaSistemas()
        {
            SistemasBO sis_Minvu = new SistemasBO();

            SistemasBUSINESS cargador = new SistemasBUSINESS();

            // Se le cargan los sistemas a la variable declarada.

            sis_Minvu.ListaSistemas = cargador.obtenerSistemas();
            ListaSistemas = sis_Minvu.ListaSistemas;
        }
    }
}