using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class ProyectosBO
    {
        public int idProyecto{ get; set; }
        public string Nombre_proyecto { get; set; }
        public int id_estado_proyecto { get; set; }

        public string Jefe_proyecto { get; set; }

        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_term_plan { get; set; }

        public int costo_proyecto { get; set; }

        public int presupuesto { get; set; }
        public string descripcion { get; set; }

        public List<ProyectosBO> ListaProyectosMUNIN { get; set; }



    }
}