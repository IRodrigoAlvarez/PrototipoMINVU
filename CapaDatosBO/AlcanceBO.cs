using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class AlcanceBO
    {
        public int idAlcance { get; set; }
        public String DescripcionAlcance { get; set; }
        public List<AlcanceBO> ListaAlcances { get; set; }
    }
}