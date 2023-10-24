using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class ReporteGeneralBO
    {

        // REPORTE PARA EL GRÁFICO DE BARRAS
        public int idReporte { get; set; }
        public String LabelEjeX { get; set; }
        public String LabelEjeY { get; set; }
        public String CantidadEjeX { get; set; }

        public String CantidadEjeY { get; set; }
        public int IdEjeY { get; set; }

        public List<ReporteGeneralBO> ListaReporte { get; set; }



    }
}