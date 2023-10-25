using CapaDatosBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosNEGOCIO
{
    public class SistemasBUSINESS
    {

        // FUNCIONES PARA EL BACK-END DEL PROTOTIPO>3
        public void EditarSistemaGeneral(int idsistema, SistemasBO sistemaeditado) 
        {

            CapaDatosDATA.DA.SistemasDA back_usuario = new CapaDatosDATA.DA.SistemasDA();

            back_usuario.EditarSistemaGeneral(idsistema, sistemaeditado);


        }

        public SistemasBO obtenerSistemasbyID(int id_sistema)
        {
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();

            return back_usuario.TraeSistemabyid(id_sistema);

        }

        public void agregarsistema(SistemasBO sistema)
        {

            CapaDatosDATA.DA.SistemasDA back_usuario = new CapaDatosDATA.DA.SistemasDA();
            CapaDatosDATA.DAO.SistemasDAO back_usuario2 = new CapaDatosDATA.DAO.SistemasDAO();

            int maxid = back_usuario2.obtenerMaxidtablasistemas();
            sistema.idSistema = maxid + 1;



            back_usuario.agregasistemageneral(sistema);


        }

        public void agregarsubsistema(SubSistemasBO sistema)
        {

            CapaDatosDATA.DA.SubSistemasDA back_usuario = new CapaDatosDATA.DA.SubSistemasDA();

            CapaDatosDATA.DAO.SubSistemaDAO back_usuario2 = new CapaDatosDATA.DAO.SubSistemaDAO();

            int maxid = back_usuario2.obtenerMaxidtablasubsistemas();
            sistema.idSubSistema = maxid + 1;



            back_usuario.agregasubsistema(sistema);


        }

        public List<ReporteGeneralBO> ReporteINTEEX() 
        {

            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaReporteINTEEX();

        }


        public List<ReporteGeneralBO> ReporteINTEIN()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaReporteINTEIN();

        }


        public List<ReporteGeneralBO> ReporteSISTEMAXVARIABLE(string control_select)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaSISTEMAXVARIABLE(control_select);

        }


















        // FUNCIONES PARA LLENAR COMBOS...

        public List<SistemasBO> obtenerSistemas()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaSistemas();

        }
        public List<SistemasBO> obtenerSistemasby(int ambiente)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaSistemasby(ambiente);

        }
        public List<EstadosBO> obtenerEstados()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaEstados();

        }
        public List<JefesBO> obtenerJefesProyectos()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaJefesproyectos();

        }
        public List<AmbienteBO> obtenerAmbientes()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaAmbientes();

        }
        public List<AreasBO> obtenerAreas()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaAreas();

        }
        public List<DataownerBO> obtenerDO()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaDO();

        }
        public List<ControlBO> obtenerControlAcceso()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaControlAcceso();

        }
        public List<AlcanceBO> obtenerAlcances()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaAlcance();

        }
        public List<RegionBO> obtenerRegiones()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaRegiones();

        }
        public List<LegacyBO> obtenerLegacy()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaLegacy();

        }
        public List<TipoSistemasBO> obtenerTiposistemas()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaTiposistemas();

        }
        public List<TecnologiaBO> obtenerTecnologias()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemasDAO back_usuario = new CapaDatosDATA.DAO.SistemasDAO();
            return back_usuario.cargaTecnologias();

        }

    }
}