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

     
      

        public string NombreSistemas { get; set; }
        public List<SistemasBO> ListaSistemas { get; set; }
        public string DescripcionSistema { get; set; }
        public int FkSubSistema { get; set; }




        // TABLA SUBSISTEMAS
        public int idSubSistema { get; set; }
        public string NombreSubSistema { get; set; }
        
        public int idJefeProyecto { get; set; }

        public int idAmbiente { get; set; }


        public List<AmbienteBO> ListaAmbientes { get; set; }

        public List<SubSistemasBO> ListaSubSistemas { get; set; }

        public List<JefesBO> ListaJefesProyectos { get; set; }
        


        public int Costo_Proyecto { get; set; }
        public int Presupuesto { get; set; }
        public string Descripcion { get; set; }


        public List<EstadosBO> ListaEstados { get; set; }





        public void CargaParametros()
        {
            SistemasBO sis_Minvu = new SistemasBO();
            EstadosBO estadosBO = new EstadosBO();
            AmbienteBO ambientes = new AmbienteBO();




            SistemasBUSINESS cargador = new SistemasBUSINESS();
            // Se le cargan los sistemas a la variable declarada.

            ambientes.ListaAmbientes = cargador.obtenerAmbientes();
            ListaAmbientes = ambientes.ListaAmbientes;



            sis_Minvu.ListaSistemas = cargador.obtenerSistemas();
            ListaSistemas = sis_Minvu.ListaSistemas;

                

            estadosBO.ListaEstados = cargador.obtenerEstados();
            ListaEstados = estadosBO.ListaEstados;
               
        }


        public void CargaSubsistemasbyID(int id_sistema)
        {

            SistemasBO sis_Minvu = new SistemasBO();

            SubSistemasBO subsis = new SubSistemasBO();

            SistemasBUSINESS cargador = new SistemasBUSINESS();
            // Se le cargan los sistemas a la variable declarada.




            subsis.ListaSubSistemas = cargador.obtenerSubSistemasbyID(id_sistema);
            ListaSubSistemas = subsis.ListaSubSistemas;


            sis_Minvu.ListaJefesProyectos = cargador.obtenerJefesProyectos();
            ListaJefesProyectos = sis_Minvu.ListaJefesProyectos;

        }










    }
}