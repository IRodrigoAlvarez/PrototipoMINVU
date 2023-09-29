using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class TecnologiaBO
    {
        public int idTecnologia { get; set; }
        public String TipoTecnologia { get; set; }
        public List<TecnologiaBO> ListaTecnologias { get; set; }

    }
}