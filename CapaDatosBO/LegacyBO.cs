using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class LegacyBO
    {
        public int idLegacy { get; set; }
        public String DescripcionLegacy { get; set; }
        public List<LegacyBO> ListaLegacy { get; set; }

    }
}