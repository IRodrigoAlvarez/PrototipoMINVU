using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class IntegraBO
    {
        public int id_integracion { get; set; }
        public int id_sistemaorigen { get; set; }
        public int id_sistemadestino { get; set; }
        public int id_sistemadestino2 { get; set; }
        public int id_moduloorigen { get; set; }
        public int id_modulodestino { get; set; }
        public int id_modulodestino2 { get; set; }
        public int id_tipointegracion { get; set; }

        public int id_entidadexterna { get; set; }



        public String nombreintegracion { get; set; }
        public String nombre_origen { get; set; }
        public String nombre_destino { get; set; }
        public String nombre_destino2 { get; set; }

        public String tipo_integracion { get; set; }


        public List<IntegraBO> ListaIntegraciones { get; set; }

    }
}