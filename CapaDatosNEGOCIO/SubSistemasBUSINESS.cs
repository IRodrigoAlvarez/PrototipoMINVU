﻿using CapaDatosBO;
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

        public SubSistemasBO TraeCaracteristicasSubsistema(int id_subsistema)
        {
            //se cargan los sistemas en la capa de datos DAO
            CapaDatosDATA.DAO.SubSistemaDAO back_usuario = new CapaDatosDATA.DAO.SubSistemaDAO();
            return back_usuario.CaracteristicasSubsistema(id_subsistema);

        }

    }
}