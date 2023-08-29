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

        public int idSistemas { get; set; }
        public int idAccion { get; set; }

        public string NombreSistemas { get; set; }
        public List<SistemasBO> ListaSistemas { get; set; }
        public List<AccionBO> ListaAccionMUNIN { get; set; }


        
        // MUNIN
        public int idProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string JefeProyecto { get; set; }
        public int idEstadoProyecto { get; set; }
        public DateTime Fecha_Inicio_Proyecto { get; set; }
        public DateTime Fecha_Termino_Proyecto { get; set; }
        public int Costo_Proyecto { get; set; }
        public int Presupuesto { get; set; }
        public string Descripcion { get; set; }

        public List<ProyectosBO> ListaProyectosMUNIN { get; set; }

        public List<EstadosBO> ListaEstadoProyectosMUNIN { get; set; }





        public void CargaSistemas()
        {
            SistemasBO sis_Minvu = new SistemasBO();
            SistemasBUSINESS cargador = new SistemasBUSINESS();
            // Se le cargan los sistemas a la variable declarada.
            sis_Minvu.ListaSistemas = cargador.obtenerSistemas();
            ListaSistemas = sis_Minvu.ListaSistemas;
        }


        public void CargaProyectosMUNIN()
        {
            ProyectosBO Proyecto_MUNIN = new ProyectosBO();
            AccionBO opcion_accion = new AccionBO();
            EstadosBO estadosBO = new EstadosBO();

            MuninBUSINESS cargador = new MuninBUSINESS();


            // Se le cargan los proyectos y las acciones del sistema a las variables declaradas.
            Proyecto_MUNIN.ListaProyectosMUNIN = cargador.obtenerProyectos();
            opcion_accion.ListaAccionMUNIN=cargador.obtenerAcciones();
            estadosBO.ListaEstadoProyectosMUNIN = cargador.obtenerEstados();




            ListaEstadoProyectosMUNIN = estadosBO.ListaEstadoProyectosMUNIN;
            ListaProyectosMUNIN = Proyecto_MUNIN.ListaProyectosMUNIN;
            ListaAccionMUNIN = opcion_accion.ListaAccionMUNIN;


        }

     





    }
}