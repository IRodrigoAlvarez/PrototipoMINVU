using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class SubSistemasBO
    {

        public int idSubSistema { get; set; }
        public string NombreSubSistema { get; set; }
        public string NombreJefeProyecto { get; set; }

        public string Descripcion { get; set; }
        public string URLinicio { get; set; }
        public string EstadoSubSistema { get; set; }
        public string URLdatos { get; set; }
        public int CostoSistema { get; set; }
        public List<SubSistemasBO> ListaSubSistemas { get; set; }




    }
}