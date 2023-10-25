using CapaDatosBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosNEGOCIO
{
    public class SubSistemasBUSINESS
    {
        public List<SubSistemasBO> obtenerSubSistemasbyID(int id_sistema)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SubSistemaDAO back_usuario = new CapaDatosDATA.DAO.SubSistemaDAO();
            return back_usuario.cargaSubSistemasbyID(id_sistema);

        }

        public List<SubSistemasBO> obtenerSubSistemas()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SubSistemaDAO back_usuario = new CapaDatosDATA.DAO.SubSistemaDAO();
            return back_usuario.CargaSubsistemas();

        }


        public SubSistemasBO TraeCaracteristicasSubsistema(int id_subsistema)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SubSistemaDAO back_usuario = new CapaDatosDATA.DAO.SubSistemaDAO();
            return back_usuario.CaracteristicasSubsistema(id_subsistema);

        }




        public void EditarSubSistema(int idsistema, SubSistemasBO SistemaNuevo)
        {

            CapaDatosDATA.DA.SubSistemasDA back_usuario = new CapaDatosDATA.DA.SubSistemasDA();

            back_usuario.EditarSubSistema(idsistema, SistemaNuevo);

        }











        public List<ReporteGeneralBO> ReporteINTEEX()
        {

            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SubSistemaDAO back_usuario = new CapaDatosDATA.DAO.SubSistemaDAO();
            return back_usuario.cargaReporteINTEEX();

        }


        public List<ReporteGeneralBO> ReporteINTEIN()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SubSistemaDAO back_usuario = new CapaDatosDATA.DAO.SubSistemaDAO();
            return back_usuario.cargaReporteINTEIN();

        }
    }
}