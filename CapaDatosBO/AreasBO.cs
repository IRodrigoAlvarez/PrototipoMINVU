using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class AreasBO
    {

        public int idArea { get; set; }
        public String DescripcionArea { get; set; }
        public List<AreasBO> ListaAreas { get; set; }
    }
}