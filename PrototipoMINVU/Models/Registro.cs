using CapaDatosBO;
using CapaDatosNEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrototipoMINVU.Models
{
    public class Registro
    {

        // PROTOTIPO


        // SISTEMAS

        public int idSistemas { get; set; }
      

        public string NombreSistemas { get; set; }
        public List<SistemasBO> ListaSistemas { get; set; }
        public int idTipoSistema { get; set; }

        public int idEstados { get; set; }
        public int idAmbiente { get; set; }

        public int idArea { get; set; }
        public int idUsuario { get; set; }

        public int idRegion { get; set; }

        public int idIntegracion { get; set; }



        // TABLA SUBSISTEMAS
        public int idSubSistema { get; set; }
        public string NombreSubSistema { get; set; }
        public int CostoSubSistema { get; set; }
        public string URL { get; set; }
        public int idTecnologia { get; set; }
        public int idJefeProyecto { get; set; }




        public List<SubSistemasBO> ListaSubSistemas { get; set; }

        public List<JefesBO> ListaJefesProyectos { get; set; }
        


        public DateTime Fecha_Inicio_Proyecto { get; set; }
        public DateTime Fecha_Termino_Proyecto { get; set; }
        public int Costo_Proyecto { get; set; }
        public int Presupuesto { get; set; }
        public string Descripcion { get; set; }


        public List<EstadosBO> ListaEstados { get; set; }





        public void CargaSistemas()
        {
            SistemasBO sis_Minvu = new SistemasBO();
            SubSistemasBO subsis = new SubSistemasBO();       
            EstadosBO estadosBO = new EstadosBO();





            SistemasBUSINESS cargador = new SistemasBUSINESS();
            // Se le cargan los sistemas a la variable declarada.



            sis_Minvu.ListaSistemas = cargador.obtenerSistemas();
            ListaSistemas = sis_Minvu.ListaSistemas;

            sis_Minvu.ListaJefesProyectos = cargador.obtenerJefesProyectos();
            ListaJefesProyectos = sis_Minvu.ListaJefesProyectos;
                


            subsis.ListaSubSistemas = cargador.obtenerSubSistemas();
            ListaSubSistemas = subsis.ListaSubSistemas;

            estadosBO.ListaEstados = cargador.obtenerEstados();
            ListaEstados = estadosBO.ListaEstados;
               
        }


       

     





    }
}