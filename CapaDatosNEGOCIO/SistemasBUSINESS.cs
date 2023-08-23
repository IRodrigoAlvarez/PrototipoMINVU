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
    }
}