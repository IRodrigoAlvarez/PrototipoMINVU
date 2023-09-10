using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class AmbienteBO
    {
        public int idAmbiente { get; set; }
        public String DescripcionAmbiente { get; set; }
        public List<AmbienteBO> ListaAmbientes { get; set; }

    }
}