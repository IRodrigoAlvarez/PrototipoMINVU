using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class UsuarioBO
    {
        public String strNombre { get; set; }

        public String Correoelectronico { get; set; }


        public String strPass { get; set; }

        public String strRepeatPass { get; set; }

        public String strNewPass { get; set; }






        public int intIDtipousuario { get; set; }


        public String strTipousuario { get; set; }



        public Boolean boolVigente { get; set; }
        public Boolean boolGenerica { get; set; }

        public int idUsuario { get; set; }
        public int intRut { get; set; }

 
    }
}