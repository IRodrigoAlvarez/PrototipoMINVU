using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrototipoMINVU.Controllers
{
    public class ControlController : Controller
    {
        // FUNCIONES PARA EL RETORNO DE VISTAS

        public ActionResult ControlSistemas()
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {               
                return View();
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }

    }
}
