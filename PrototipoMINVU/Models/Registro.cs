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

        public List<SistemasBO> ListaSistemasP { get; set; }
        public List<SistemasBO> ListaSistemasD { get; set; }
        public List<SistemasBO> ListaSistemasT { get; set; }
        public SubSistemasBO SubSistemaExample { get; set; }


        // TABLA SUBSISTEMAS
        public int idAmbiente { get; set; }
        public int idDataOwner { get; set; }

        public List<AmbienteBO> ListaAmbientes { get; set; }
        public List<DataownerBO> ListaDO { get; set; }
        public List<AreasBO> ListaAreas { get; set; }
        public List<EstadosBO> ListaEstados { get; set; }
        public List<SubSistemasBO> ListaSubSistemas { get; set; }
        public List<JefesBO> ListaJefesProyectos { get; set; }

        public List<ControlBO> ListaControlAcceso { get; set; }

        public List<RegionBO> ListaRegion { get; set; }
        public List<TecnologiaBO> ListaTecnologia { get; set; }
        public List<LegacyBO> ListaLegacy { get; set; }
        public List<TipoSistemasBO> ListaTipoSistemas { get; set; }
        public List<AlcanceBO> ListaAlcance { get; set; }


        public int Costo_Proyecto { get; set; }
        public int Presupuesto { get; set; }
        public string Descripcion { get; set; }
        public string Nombre_dueñodatos { get; set; }









        public void CargaSistemas()
        {
            SistemasBO sis_Minvu = new SistemasBO();
            SistemasBUSINESS cargador = new SistemasBUSINESS();
            AmbienteBO ambientes = new AmbienteBO();

            // Se le cargan los sistemas a la variable declarada.            
            sis_Minvu.ListaSistemas = cargador.obtenerSistemas();

            ambientes.ListaAmbientes = cargador.obtenerAmbientes();
            ListaAmbientes = ambientes.ListaAmbientes;

            // se obtienen las listas de los sistemas en produccion, desarrollo y testing respectivamente
            sis_Minvu.ListaSistemasP = cargador.obtenerSistemasby(3);
            sis_Minvu.ListaSistemasD = cargador.obtenerSistemasby(1);
            sis_Minvu.ListaSistemasT = cargador.obtenerSistemasby(2);



            ListaSistemas = sis_Minvu.ListaSistemas;
            ListaSistemasP = sis_Minvu.ListaSistemasP;
            ListaSistemasD = sis_Minvu.ListaSistemasD;
            ListaSistemasT = sis_Minvu.ListaSistemasT;

        }



        public void CargarCombos() 
        {
            EstadosBO estadosBO = new EstadosBO();
            AreasBO areas = new AreasBO();
            AmbienteBO ambientes = new AmbienteBO();
            SistemasBO sis_Minvu = new SistemasBO();
            DataownerBO dueño_datos = new DataownerBO();
            ControlBO control = new ControlBO();
            AlcanceBO alcance = new AlcanceBO();
            RegionBO region = new RegionBO();
            LegacyBO legacy = new LegacyBO();
            TipoSistemasBO tiposistema = new TipoSistemasBO();
            TecnologiaBO tipotecnologia = new TecnologiaBO();

            SistemasBUSINESS cargador = new SistemasBUSINESS();



            tipotecnologia.ListaTecnologias = cargador.obtenerTecnologias();
            ListaTecnologia = tipotecnologia.ListaTecnologias;


            tiposistema.ListaTiposSistemas = cargador.obtenerTiposistemas();
            ListaTipoSistemas = tiposistema.ListaTiposSistemas;


            legacy.ListaLegacy = cargador.obtenerLegacy();
            ListaLegacy = legacy.ListaLegacy;


            region.ListaRegiones = cargador.obtenerRegiones();
            ListaRegion = region.ListaRegiones;


            alcance.ListaAlcances = cargador.obtenerAlcances();
            ListaAlcance = alcance.ListaAlcances;

            control.ListaControlAcceso = cargador.obtenerControlAcceso();
            ListaControlAcceso = control.ListaControlAcceso;


            dueño_datos.ListaDataOwners = cargador.obtenerDO();
            ListaDO = dueño_datos.ListaDataOwners;

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