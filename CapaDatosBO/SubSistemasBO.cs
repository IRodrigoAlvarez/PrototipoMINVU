using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class SubSistemasBO
    {

        public int idSubSistema { get; set; }
        public int CostoSistema { get; set; }

        public string NombreSubSistema { get; set; }
        public string URL { get; set; }

        public List<SubSistemasBO> ListaSubSistemas { get; set; }




    }
}