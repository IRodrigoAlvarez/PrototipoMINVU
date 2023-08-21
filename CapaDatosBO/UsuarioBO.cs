using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class UsuarioBO
    {
        public int intID { get; set; }
        public String strNombre { get; set; }

        public String strPass { get; set; }

        public Boolean boolVigente { get; set; }
        public Boolean boolGenerica { get; set; }

        public int idUsuario { get; set; }
        public int intRut { get; set; }

 
    }
}