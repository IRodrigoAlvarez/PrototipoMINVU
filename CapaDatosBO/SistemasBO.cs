using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class SistemasBO
    {
        public int idSistema { get; set; }
        public string NombreSistema { get; set; }
        public string NombreSubSistema { get; set; }


        public string NombreJefeProyecto { get; set; }
        public string estado { get; set; }


        public List<SistemasBO> ListaSistemas { get; set; }

        public List<JefesBO> ListaJefesProyectos { get; set; }


    }
}