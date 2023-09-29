using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class TipoSistemasBO
    {
        public int idTipoSistema { get; set; }
        public String TipoSistema { get; set; }
        public List<TipoSistemasBO> ListaTiposSistemas { get; set; }

    }
}