using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class ModuloBO
    {
        public int idSistema { get; set; }

        public string NombreSistema { get; set; }

        public string descripcion { get; set; }
        public int id_AMBIENTE { get; set; }
        public string AmbienteAlojado { get; set; }

        public int id_estado { get; set; }

        public string DescripcionEstado { get; set; }

        public List<ModuloBO> ListaModulos { get; set; }

        public List<ModuloBO> ListaSistemasP { get; set; }

        public List<ModuloBO> ListaSistemasD { get; set; }

        public List<ModuloBO> ListaSistemasT { get; set; }


        public List<JefesBO> ListaJefesProyectos { get; set; }


    }
}