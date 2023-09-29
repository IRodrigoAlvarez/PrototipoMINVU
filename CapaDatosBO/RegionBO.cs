using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class RegionBO
    {
        public int idRegion { get; set; }
        public String NombreRegion { get; set; }
        public List<RegionBO> ListaRegiones { get; set; }

    }
}