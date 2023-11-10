using CapaDatosBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosNEGOCIO
{
    public class ModulosBUSINESS
    {

        // FUNCIONES PARA EL BACK-END DEL PROTOTIPO>3
        public void EditarModulo(int idsistema, ModuloBO sistemaeditado) 
        {

            CapaDatosDATA.DA.ModulosDA back_usuario = new CapaDatosDATA.DA.ModulosDA();

            back_usuario.EditarModulo(idsistema, sistemaeditado);


        }

        public ModuloBO obtenerModulobyID(int id_sistema)
        {
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();

            return back_usuario.TraeModulobyid(id_sistema);

        }

        public void agregarmodulo(ModuloBO sistema)
        {

            CapaDatosDATA.DA.ModulosDA back_usuario = new CapaDatosDATA.DA.ModulosDA();
            CapaDatosDATA.DAO.ModulosDAO back_usuario2 = new CapaDatosDATA.DAO.ModulosDAO();

            int maxid = back_usuario2.obtenerMaxidtablamodulos();
            sistema.idSistema = maxid + 1;
            back_usuario.agregaMODULO(sistema);

        }


        public void EliminarModulo(int id_sistemadelete)
        {

            CapaDatosDATA.DA.ModulosDA back_usuario = new CapaDatosDATA.DA.ModulosDA();

            back_usuario.EliminaModulo(id_sistemadelete);
        }






        // FUNCIONES PARA LLENAR COMBOS...

        public List<ModuloBO> obtenerModulos()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaModulos();

        }
        public List<ModuloBO> obtenerModulosby(int ambiente)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaModulosby(ambiente);

        }
        public List<EstadosBO> obtenerEstados()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaEstados();

        }
        public List<JefesBO> obtenerJefesProyectos()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaJefesproyectos();

        }
        public List<AmbienteBO> obtenerAmbientes()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaAmbientes();

        }
        public List<AreasBO> obtenerAreas()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaAreas();

        }
        public List<DataownerBO> obtenerDO()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaDO();

        }
        public List<ControlBO> obtenerControlAcceso()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaControlAcceso();

        }
        public List<AlcanceBO> obtenerAlcances()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaAlcance();

        }
        public List<RegionBO> obtenerRegiones()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaRegiones();

        }
        public List<LegacyBO> obtenerLegacy()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaLegacy();

        }
        public List<TipoSistemasBO> obtenerTiposistemas()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaTiposistemas();

        }
        public List<TecnologiaBO> obtenerTecnologias()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.ModulosDAO back_usuario = new CapaDatosDATA.DAO.ModulosDAO();
            return back_usuario.cargaTecnologias();

        }

    }
}