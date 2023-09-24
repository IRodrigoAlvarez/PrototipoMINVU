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

    
        public List<SistemasBO> ListaSistemas { get; set; }

        public SubSistemasBO SubSistemaExample { get; set; }


        // TABLA SUBSISTEMAS




        public int idAmbiente { get; set; }
        public List<AmbienteBO> ListaAmbientes { get; set; }
        public List<AreasBO> ListaAreas { get; set; }
        public List<EstadosBO> ListaEstados { get; set; }

        public List<SubSistemasBO> ListaSubSistemas { get; set; }

        public List<JefesBO> ListaJefesProyectos { get; set; }
        


        public int Costo_Proyecto { get; set; }
        public int Presupuesto { get; set; }
        public string Descripcion { get; set; }


       





        public void CargaSistemas()
        {
            SistemasBO sis_Minvu = new SistemasBO();            
            SistemasBUSINESS cargador = new SistemasBUSINESS();
            // Se le cargan los sistemas a la variable declarada.            
            sis_Minvu.ListaSistemas = cargador.obtenerSistemas();
            ListaSistemas = sis_Minvu.ListaSistemas;                                        
        }


        public void CargarCombos() 
        {
            EstadosBO estadosBO = new EstadosBO();
            AreasBO areas = new AreasBO();
            AmbienteBO ambientes = new AmbienteBO();
            SistemasBO sis_Minvu = new SistemasBO();


            SistemasBUSINESS cargador = new SistemasBUSINESS();


            areas.ListaAreas = cargador.obtenerAreas();
            ListaAreas = areas.ListaAreas;

            estadosBO.ListaEstados = cargador.obtenerEstados();
            ListaEstados = estadosBO.ListaEstados;

            sis_Minvu.ListaJefesProyectos = cargador.obtenerJefesProyectos();
            ListaJefesProyectos = sis_Minvu.ListaJefesProyectos;

            ambientes.ListaAmbientes = cargador.obtenerAmbientes();
            ListaAmbientes = ambientes.ListaAmbientes;


        }

        public void CargaSubsistemasbyID(int id_sistema)
        {

            SubSistemasBO subsis = new SubSistemasBO();
            SubSistemasBUSINESS cargador = new SubSistemasBUSINESS();
            // Se le cargan los sistemas a la variable declarada.


            subsis.ListaSubSistemas = cargador.obtenerSubSistemasbyID(id_sistema);
            ListaSubSistemas = subsis.ListaSubSistemas;
            
        }


        public void TraeCaractersticasSubSistema(int id_subsistema)
        {

            SubSistemasBO subsistema = new SubSistemasBO();

            SubSistemasBUSINESS cargador = new SubSistemasBUSINESS();
            // Se le cargan los sistemas a la variable declarada.

            subsistema = cargador.TraeCaracteristicasSubsistema(id_subsistema);

            SubSistemaExample = subsistema;


        }







    }
}