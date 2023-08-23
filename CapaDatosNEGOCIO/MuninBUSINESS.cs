using CapaDatosBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosNEGOCIO
{
    public class MuninBUSINESS
    {
        public List<ProyectosBO> obtenerProyectos()
        {
            //se cargan los proyectos en la capa de datos DAO(dataset)

            CapaDatosDATA.DAO.MuninDAO back_usuario = new CapaDatosDATA.DAO.MuninDAO();
            return back_usuario.cargaProyectos();

        }
    }
}