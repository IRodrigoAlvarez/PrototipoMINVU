using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class EstadosBO
    {
       
        public int idEstado { get; set; }
        public String DescripcionEstado { get; set; }
        public List<EstadosBO> ListaEstados { get; set; }


    }
}