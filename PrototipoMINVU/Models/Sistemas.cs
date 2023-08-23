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

        // PROTOTIPO

        public int idSistemas { get; set; }
        public string NombreSistemas { get; set; }
        public List<SistemasBO> ListaSistemas { get; set; }






        // MUNIN
        public int idProyecto { get; set; }
        public string NombreProyectos { get; set; }
        public List<ProyectosBO> ListaProyectosMUNIN { get; set; }


        public void CargaSistemas()
        {
            SistemasBO sis_Minvu = new SistemasBO();

            SistemasBUSINESS cargador = new SistemasBUSINESS();

            // Se le cargan los sistemas a la variable declarada.

            sis_Minvu.ListaSistemas = cargador.obtenerSistemas();
            ListaSistemas = sis_Minvu.ListaSistemas;
        }






        public void CargaProyectosMUNIN()
        {
            ProyectosBO Proyecto_MUNIN = new ProyectosBO();

            MuninBUSINESS cargador = new MuninBUSINESS();

            // Se le cargan los sistemas a la variable declarada.

            Proyecto_MUNIN.ListaProyectosMUNIN = cargador.obtenerProyectos();



            ListaProyectosMUNIN = Proyecto_MUNIN.ListaProyectosMUNIN;
        }
    }
}