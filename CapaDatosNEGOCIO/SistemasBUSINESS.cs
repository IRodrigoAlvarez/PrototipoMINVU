using CapaDatosBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosNEGOCIO
{
    public class SistemasBUSINESS
    {
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