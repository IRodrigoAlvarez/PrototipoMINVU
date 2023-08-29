using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class AccionBO
    {
        public int idAccion { get; set; }
        public String DescripcionAccion { get; set; }

        public List<AccionBO> ListaAccionMUNIN { get; set; }

    }
}