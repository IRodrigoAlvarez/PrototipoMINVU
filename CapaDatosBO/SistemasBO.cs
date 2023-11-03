using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class SistemasBO
    {

        public int id_sistema { get; set; }

        public int idAmbiente { get; set; }

        public string NombreSistema { get; set; } 
        public string DescripcionSistema { get; set; }
        public string URLinicio { get; set; }
        public string URLdatos { get; set; }
        public string DecretoAfecto { get; set; }
        public string CostoSistema { get; set; }


        public int id_estado { get; set; }

        public string EstadoSistema { get; set; }
        public int id_jefeproyecto { get; set; }

        public string NombreJefeProyecto { get; set; }



        public string AmbienteAlojado { get; set; }


        public int id_dataowner { get; set; }


        public string DueñoDatos { get; set; }

        public int id_control { get; set; }

        public string TipoControlAcceso { get; set; }
        public int id_area { get; set; }

        public string TipoArea { get; set; }
        public int id_tiposistema { get; set; }
        public string TipoSistema { get; set; }
        public int id_tipotecnologia { get; set; }

        public string TipoTecnologia { get; set; }
        public int id_legacy { get; set; }

        public string TipoLegacy { get; set; }
        public int id_alcance { get; set; }

        public string TipoAlcance { get; set; }
        public int id_region { get; set; }

        public string Region { get; set; }
   
        public List<SistemasBO> ListaSistemas { get; set; }




    }
}