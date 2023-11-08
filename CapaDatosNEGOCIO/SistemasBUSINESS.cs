using CapaDatosBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosNEGOCIO
{
    public class SistemasBUSINESS
    {
        public SistemasBO obtenerSistemasbyID(int id_sistema)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemaDAO back_usuario = new CapaDatosDATA.DAO.SistemaDAO();
            return back_usuario.cargaSistemabyID(id_sistema);

        }

        public List<SistemasBO> obtenerSistemas()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemaDAO back_usuario = new CapaDatosDATA.DAO.SistemaDAO();
            return back_usuario.CargaSistemas();

        }


        public SistemasBO TraeCaracteristicasSistema(int id_sistema)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemaDAO back_usuario = new CapaDatosDATA.DAO.SistemaDAO();
            return back_usuario.CaracteristicasSistema(id_sistema);

        }




        public void EditarSistema(int idsistema, SistemasBO SistemaNuevo)
        {

            CapaDatosDATA.DA.SistemasDA back_usuario = new CapaDatosDATA.DA.SistemasDA();

            back_usuario.EditarSistema(idsistema, SistemaNuevo);

        }


        public void agregarsistema(SistemasBO sistema)
        {

            CapaDatosDATA.DA.SistemasDA back_usuario = new CapaDatosDATA.DA.SistemasDA();

            CapaDatosDATA.DAO.SistemaDAO back_usuario2 = new CapaDatosDATA.DAO.SistemaDAO();

            int maxid = back_usuario2.obtenerMaxidtablasistemas();
            sistema.id_sistema = maxid + 1;



            back_usuario.agregasistema(sistema);


        }

        public void EliminarSistema(int id_sistemadelete)
        {

            CapaDatosDATA.DA.SistemasDA back_usuario = new CapaDatosDATA.DA.SistemasDA();

            back_usuario.EliminarSistema(id_sistemadelete);
        }

        public List<ReporteGeneralBO> ReporteSISTEMAXVARIABLE(string control_select)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemaDAO back_usuario = new CapaDatosDATA.DAO.SistemaDAO();
            return back_usuario.cargaSISTEMAXVARIABLE(control_select);

        }



        public List<ReporteGeneralBO> ReporteINTEEX()
        {

            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemaDAO back_usuario = new CapaDatosDATA.DAO.SistemaDAO();
            return back_usuario.cargaReporteINTEEX();

        }


        public List<ReporteGeneralBO> ReporteINTEIN()
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemaDAO back_usuario = new CapaDatosDATA.DAO.SistemaDAO();
            return back_usuario.cargaReporteINTEIN();

        }


        public List<ReporteGeneralBO> ReporteSUBSISTEMAXVARIABLE(string control_select)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SistemaDAO back_usuario = new CapaDatosDATA.DAO.SistemaDAO();
            return back_usuario.cargaSUBSISTEMAXVARIABLE(control_select);

        }







    }
}