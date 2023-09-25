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

        public string descripcion { get; set; }
        public int id_AMBIENTE { get; set; }

        public List<SistemasBO> ListaSistemas { get; set; }

        public List<SistemasBO> ListaSistemasP { get; set; }

        public List<SistemasBO> ListaSistemasD { get; set; }

        public List<SistemasBO> ListaSistemasT { get; set; }


        public List<JefesBO> ListaJefesProyectos { get; set; }


    }
}