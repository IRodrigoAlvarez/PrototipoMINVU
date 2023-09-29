using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class ControlBO
    {
        public int idControlAcceso { get; set; }
        public String TipoControl { get; set; }
        public List<ControlBO> ListaControlAcceso { get; set; }


    }
}