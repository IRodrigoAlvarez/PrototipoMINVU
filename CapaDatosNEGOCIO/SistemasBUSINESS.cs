﻿using CapaDatosBO;
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

    }
}