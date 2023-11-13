using CapaDatosBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosNEGOCIO
{
    public class IntegracionesBUSINESS
    {

        public List<IntegraBO> obtenerTipoIntegraciones() {

            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.IntegraDAO back_usuario = new CapaDatosDATA.DAO.IntegraDAO();
            return back_usuario.cargaTipoIntegracion();

        }


        public void AgregarIntegracion(IntegraBO integracion)
        {

            //se cargan los sistemas en la capa de datos DA
            CapaDatosDATA.DA.IntegraDA back_usuario = new CapaDatosDATA.DA.IntegraDA();
            CapaDatosDATA.DAO.IntegraDAO back_usuario2 = new CapaDatosDATA.DAO.IntegraDAO();

            int maxid = back_usuario2.obtenerMaxidtablaintegraciones();

            integracion.id_integracion = maxid + 1;



            back_usuario.AddIntegracion(integracion);

        }

        public List<IntegraBO> obtenerIntegraciones()
        {

            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.IntegraDAO back_usuario = new CapaDatosDATA.DAO.IntegraDAO();
            return back_usuario.cargaIntegraciones();

        }


        public List<IntegraBO> obtenerIntegracionesSistemaby(int sistema)
        {

            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.IntegraDAO back_usuario = new CapaDatosDATA.DAO.IntegraDAO();
            return back_usuario.cargaIntegracionesSistemasby(sistema);

        }



        public IntegraBO obtenerIntegracionby(int integracion)
        {

            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.IntegraDAO back_usuario = new CapaDatosDATA.DAO.IntegraDAO();
            return back_usuario.cargaIntegracionby(integracion);

        }

    }
}