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

        public string SVGContent { get; set; }

        public int  id_Estado { get; set; }

        public int id_reportesistema { get; set; }

        public List<ModuloBO> ListaModulos { get; set; }
    
        public SistemasBO SistemaExample { get; set; }
        public ModuloBO ModuloExample { get; set; }

        public string DescripcionEstado { get; set; }

        public int idAmbiente { get; set; }








        public List<AmbienteBO> ListaAmbientes { get; set; }
        public List<DataownerBO> ListaDO { get; set; }
        public List<AreasBO> ListaAreas { get; set; }
        public List<EstadosBO> ListaEstados { get; set; }



        public List<SistemasBO> ListaSistemas { get; set; }

        public List<JefesBO> ListaJefesProyectos { get; set; }

        public List<ControlBO> ListaControlAcceso { get; set; }

        public List<RegionBO> ListaRegion { get; set; }
        public List<TecnologiaBO> ListaTecnologia { get; set; }
        public List<LegacyBO> ListaLegacy { get; set; }
        public List<TipoSistemasBO> ListaTipoSistemas { get; set; }
        public List<AlcanceBO> ListaAlcance { get; set; }

        public List<ModuloBO> ListaSistemasP { get; set; }
        public List<ModuloBO> ListaSistemasD { get; set; }
        public List<ModuloBO> ListaSistemasT { get; set; }



        public void CargaModulos()
        {
            ModuloBO sis_Minvu = new ModuloBO();
            ModulosBUSINESS cargador = new ModulosBUSINESS();
            AmbienteBO ambientes = new AmbienteBO();




            ModuloExample = sis_Minvu;

            // Se le cargan los sistemas a la variable declarada.            
            sis_Minvu.ListaModulos = cargador.obtenerModulos();

            ambientes.ListaAmbientes = cargador.obtenerAmbientes();
            ListaAmbientes = ambientes.ListaAmbientes;

            // se obtienen las listas de los sistemas en produccion, desarrollo y testing respectivamente
            sis_Minvu.ListaSistemasP = cargador.obtenerModulosby(3);
            sis_Minvu.ListaSistemasD = cargador.obtenerModulosby(1);
            sis_Minvu.ListaSistemasT = cargador.obtenerModulosby(2);


            ListaModulos = sis_Minvu.ListaModulos;
            ListaSistemasP = sis_Minvu.ListaSistemasP;
            ListaSistemasD = sis_Minvu.ListaSistemasD;
            ListaSistemasT = sis_Minvu.ListaSistemasT;



           
        }

        public void CargaSistemas()
        {
            SistemasBO sis_Minvu = new SistemasBO();
            SistemasBUSINESS cargador = new SistemasBUSINESS();


            sis_Minvu.ListaSistemas = cargador.obtenerSistemas();

            ListaSistemas = sis_Minvu.ListaSistemas;
        }

        public void CargarCombos() 
        {
            EstadosBO estadosBO = new EstadosBO();
            AreasBO areas = new AreasBO();
            AmbienteBO ambientes = new AmbienteBO();
            ModuloBO sis_Minvu = new ModuloBO();
            DataownerBO dueño_datos = new DataownerBO();
            ControlBO control = new ControlBO();
            AlcanceBO alcance = new AlcanceBO();
            RegionBO region = new RegionBO();
            LegacyBO legacy = new LegacyBO();
            TipoSistemasBO tiposistema = new TipoSistemasBO();
            TecnologiaBO tipotecnologia = new TecnologiaBO();

            ModulosBUSINESS cargador = new ModulosBUSINESS();



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

        public void CargaModulobyID(int id_sistema) 
        {
            ModuloBO sis_Minvu = new ModuloBO();
            ModulosBUSINESS cargador = new ModulosBUSINESS();


            sis_Minvu = cargador.obtenerModulobyID(id_sistema);
            ModuloExample = sis_Minvu;

            //CargaSubsistemasbyID(id_sistema);

        }















        public void TraeCaractersticasSistema(int id_sistema)
        {

            SistemasBO sistema = new SistemasBO();
            SistemasBUSINESS cargador = new SistemasBUSINESS();
            // Se le cargan los sistemas a la variable declarada.

            sistema = cargador.TraeCaracteristicasSistema(id_sistema);
            SistemaExample = sistema;

        }



        public void GenerarReporteModulo(int reportesistema)
        {
            ModuloBO sis_Minvu = new ModuloBO();
            ModulosBUSINESS cargadorSistemas = new ModulosBUSINESS();

            sis_Minvu = cargadorSistemas.obtenerModulobyID(reportesistema);

           ModuloExample =  sis_Minvu;      

        }











        public void CargaSistemasbyID(int id_sistema)
        {
            SistemasBO subsis = new SistemasBO();
            SistemasBUSINESS cargador = new SistemasBUSINESS();
            // Se le cargan los sistemas a la variable declarada.

            subsis.ListaSistemas = cargador.obtenerSistemasbyID(id_sistema);
            ListaSistemas = subsis.ListaSistemas;

        }

    }
}