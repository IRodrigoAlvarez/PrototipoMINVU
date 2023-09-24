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
 
        public string DescripcionSubSistema { get; set; }
        public string URLinicio { get; set; }
        public string URLdatos { get; set; }
        public string DecretoAfecto { get; set; }
        public int CostoSistema { get; set; }
        public string DueñoDatos { get; set; }
        public string NombreJefeProyecto { get; set; }
        public string TipoControlAcceso { get; set; }
        public string TipoSistema { get; set; }
        public string TipoTecnologia { get; set; }

        public string TipoLegacy { get; set; }
        public string TipoAlcance { get; set; }
        public string Region { get; set; }
        public string EstadoSubSistema { get; set; }
   
        public List<SubSistemasBO> ListaSubSistemas { get; set; }




    }
}